using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using GitCommands;
using ResourceManager.Translation;

namespace GitUI
{
    public sealed partial class FormFileHistory : GitModuleForm
    {
        private readonly FilterRevisionsHelper filterRevisionsHelper;
        private readonly FilterBranchHelper filterBranchHelper;
        private AsyncLoader asyncLoader;

        private FormFileHistory()
            : this(null)
        { }

        internal FormFileHistory(GitUICommands aCommands)
            : base(aCommands)
        {
            InitializeComponent();
            asyncLoader = new AsyncLoader();
            // set tab page images
            {
                var imageList = new ImageList();
                tabControl1.ImageList = imageList;
                imageList.ColorDepth = ColorDepth.Depth8Bit;
                imageList.Images.Add(global::GitUI.Properties.Resources.IconViewFile);
                imageList.Images.Add(global::GitUI.Properties.Resources.IconDiff);
                imageList.Images.Add(global::GitUI.Properties.Resources.IconBlame);
                tabControl1.TabPages[0].ImageIndex = 0;
                tabControl1.TabPages[1].ImageIndex = 1;
                tabControl1.TabPages[2].ImageIndex = 2;
            }

            filterBranchHelper = new FilterBranchHelper(toolStripBranches, toolStripDropDownButton2, FileChanges);
            filterRevisionsHelper = new FilterRevisionsHelper(toolStripTextBoxFilter, toolStripDropDownButton1, FileChanges, toolStripLabel2, this);
        }

        public FormFileHistory(GitUICommands aCommands, string fileName, GitRevision revision, bool filterByRevision)
            : this(aCommands)
        {
            FileChanges.SetInitialRevision(revision);
            Translate();

            FileName = fileName;

            Diff.ExtraDiffArgumentsChanged += DiffExtraDiffArgumentsChanged;

            FileChanges.SelectionChanged += FileChangesSelectionChanged;
            FileChanges.DisableContextMenu();

            followFileHistoryToolStripMenuItem.Checked = Settings.FollowRenamesInFileHistory;
            fullHistoryToolStripMenuItem.Checked = Settings.FullHistoryInFileHistory;
            loadHistoryOnShowToolStripMenuItem.Checked = Settings.LoadFileHistoryOnShow;
            loadBlameOnShowToolStripMenuItem.Checked = Settings.LoadBlameOnShow;

            if (filterByRevision && revision != null && revision.Guid != null)
                filterBranchHelper.SetBranchFilter(revision.Guid, false);
        }

        public FormFileHistory(GitUICommands aCommands, string fileName)
            : this(aCommands, fileName, null, false)
        {
        }

        protected override void OnRuntimeLoad(EventArgs e)
        {
            base.OnRuntimeLoad(e);

            bool autoLoad = (tabControl1.SelectedTab == BlameTab && Settings.LoadBlameOnShow) || Settings.LoadFileHistoryOnShow;

            if (autoLoad)
                LoadFileHistory();
            else
                FileChanges.Visible = false;
        }

        private string FileName { get; set; }

        public void SelectBlameTab()
        {
            tabControl1.SelectedTab = BlameTab;
        }

        private void LoadFileHistory()
        {
            FileChanges.Visible = true;

            asyncLoader.Load(() => BuildFilter(FileName), (filter) =>
            {
                if (filter == null)
                    return;
                FileChanges.FixedFilter = filter;
                FileChanges.FiltredFileName = FileName;
                FileChanges.AllowGraphWithFilter = true;
                FileChanges.Load();
            });
        }

        private string BuildFilter(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
                return null;

            //Replace windows path separator to Linux path separator. 
            //This is needed to keep the file history working when started from file tree in
            //browse dialog.
            fileName = fileName.Replace('\\', '/');

            // we will need this later to look up proper casing for the file
            var fullFilePath = Path.Combine(Module.WorkingDir, fileName);

            //The section below contains native windows (kernel32) calls
            //and breaks on Linux. Only use it on Windows. Casing is only
            //a Windows problem anyway.
            if (Settings.RunningOnWindows() && File.Exists(fullFilePath))
            {
                // grab the 8.3 file path
                var shortPath = new StringBuilder(4096);
                NativeMethods.GetShortPathName(fullFilePath, shortPath, shortPath.Capacity);

                // use 8.3 file path to get properly cased full file path
                var longPath = new StringBuilder(4096);
                NativeMethods.GetLongPathName(shortPath.ToString(), longPath, longPath.Capacity);

                // remove the working dir and now we have a properly cased file name.
                fileName = longPath.ToString().Substring(Module.WorkingDir.Length);
            }

            if (fileName.StartsWith(Module.WorkingDir, StringComparison.InvariantCultureIgnoreCase))
                fileName = fileName.Substring(Module.WorkingDir.Length);

            FileName = fileName;

            string filter;
            if (Settings.FollowRenamesInFileHistory && !Directory.Exists(fullFilePath))
            {
                // git log --follow is not working as expected (see  http://kerneltrap.org/mailarchive/git/2009/1/30/4856404/thread)
                //
                // But we can take a more complicated path to get reasonable results:
                //  1. use git log --follow to get all previous filenames of the file we are interested in
                //  2. use git log "list of files names" to get the history graph 
                //
                // note: This implementation is quite a quick hack (by someone who does not speak C# fluently).
                // 

                var gitGetGraphCommand = new GitCommandsInstance(Module) { StreamOutput = true, CollectOutput = false };

                string arg = "log --format=\"%n\" --name-only --follow -- \"" + fileName + "\"";
                Process p = gitGetGraphCommand.CmdStartProcess(Settings.GitCommand, arg);

                // the sequence of (quoted) file names - start with the initial filename for the search.
                var listOfFileNames = new StringBuilder("\"" + fileName + "\"");

                // keep a set of the file names already seen
                var setOfFileNames = new HashSet<string> { fileName };

                string line;
                do
                {
                    line = p.StandardOutput.ReadLine();

                    if (!string.IsNullOrEmpty(line) && setOfFileNames.Add(line))
                    {
                        listOfFileNames.Append(" \"");
                        listOfFileNames.Append(line);
                        listOfFileNames.Append('\"');
                    }
                } while (line != null);

                // here we need --name-only to get the previous filenames in the revision graph
                filter = " -M -C --name-only --parents -- " + listOfFileNames;
            }
            else
            {
                // --parents doesn't work with --follow enabled, but needed to graph a filtered log
                filter = " --parents -- \"" + fileName + "\"";
            }

            if (Settings.FullHistoryInFileHistory)
            {
                filter = string.Concat(" --full-history --simplify-by-decoration ", filter);
            }

            return filter;
        }

        private void DiffExtraDiffArgumentsChanged(object sender, EventArgs e)
        {
            UpdateSelectedFileViewers();
        }

        private void FormFileHistoryLoad(object sender, EventArgs e)
        {
            Text = string.Format("File History ({0})", FileName);
        }

        private void FileChangesSelectionChanged(object sender, EventArgs e)
        {
            View.SaveCurrentScrollPos();
            Diff.SaveCurrentScrollPos();

            var selectedRows = FileChanges.GetSelectedRevisions();
            if (selectedRows.Count > 0)
            {
                GitRevision revision = selectedRows[0];
                if (revision.IsArtificial())
                    tabControl1.RemoveIfExists(BlameTab);
                else
                    tabControl1.InsertIfNotExists(2, BlameTab);
            }
            UpdateSelectedFileViewers();
        }

        private void UpdateSelectedFileViewers()
        {
            var selectedRows = FileChanges.GetSelectedRevisions();

            if (selectedRows.Count == 0) return;

            GitRevision revision = selectedRows[0];
            var children = FileChanges.GetRevisionChildren(revision.Guid);

            var fileName = revision.Name;

            if (string.IsNullOrEmpty(fileName))
                fileName = FileName;

            Text = string.Format("File History - {0}", FileName);
            if (!fileName.Equals(FileName))
                Text = Text + string.Format(" ({0})", fileName);

            if (tabControl1.SelectedTab == BlameTab)
                Blame.LoadBlame(revision, children, fileName, FileChanges, BlameTab, Diff.Encoding);
            else if (tabControl1.SelectedTab == ViewTab)
            {
                var scrollpos = View.ScrollPos;

                View.Encoding = Diff.Encoding;
                View.ViewGitItemRevision(fileName, revision.Guid);
                View.ScrollPos = scrollpos;
            }
            else if (tabControl1.SelectedTab == DiffTab)
            {
                GitItemStatus file = new GitItemStatus();
                file.IsTracked = true;
                file.Name = fileName;
                Diff.ViewPatch(FileChanges, file, "You need to select at least one revision to view diff.");
            }

        }

        private void TabControl1SelectedIndexChanged(object sender, EventArgs e)
        {
            FileChangesSelectionChanged(sender, e);
        }

        private void FileChangesDoubleClick(object sender, EventArgs e)
        {
            FileChanges.ViewSelectedRevisions();
        }

        private void OpenWithDifftoolToolStripMenuItemClick(object sender, EventArgs e)
        {
            var selectedRows = FileChanges.GetSelectedRevisions();

            string orgFileName = null;
            if (selectedRows.Count > 0)
            {
                orgFileName = selectedRows[0].Name;
            }
            FileChanges.OpenWithDifftool(FileName, orgFileName, GitUIExtensions.DiffWithRevisionKind.DiffAB);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRows = FileChanges.GetSelectedRevisions();

            if (selectedRows.Count > 0)
            {
                string orgFileName = selectedRows[0].Name;

                if (string.IsNullOrEmpty(orgFileName))
                    orgFileName = FileName;

                string fullName = Module.WorkingDir + orgFileName.Replace(Settings.PathSeparatorWrong, Settings.PathSeparator);

                using (var fileDialog = new SaveFileDialog
                {
                    InitialDirectory = Path.GetDirectoryName(fullName),
                    FileName = Path.GetFileName(fullName),
                    DefaultExt = GitCommandHelpers.GetFileExtension(fullName),
                    AddExtension = true
                })
                {
                    fileDialog.Filter =
                        "Current format (*." +
                        fileDialog.DefaultExt + ")|*." +
                        fileDialog.DefaultExt +
                        "|All files (*.*)|*.*";
                    if (fileDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        Module.SaveBlobAs(fileDialog.FileName, selectedRows[0].Guid + ":\"" + orgFileName + "\"");
                    }
                }
            }
        }

        private void followFileHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.FollowRenamesInFileHistory = !Settings.FollowRenamesInFileHistory;
            followFileHistoryToolStripMenuItem.Checked = Settings.FollowRenamesInFileHistory;

            LoadFileHistory();
        }

        private void fullHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.FullHistoryInFileHistory = !Settings.FullHistoryInFileHistory;
            fullHistoryToolStripMenuItem.Checked = Settings.FullHistoryInFileHistory;
            LoadFileHistory();
        }

        private void cherryPickThisCommitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRevisions = FileChanges.GetSelectedRevisions();
            if (selectedRevisions.Count == 1)
            {
                using (var frm = new FormCherryPick(UICommands, selectedRevisions[0]))
                    frm.ShowDialog(this);
            }
        }

        private void revertCommitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRevisions = FileChanges.GetSelectedRevisions();
            if (selectedRevisions.Count == 1)
            {
                var frm = new FormRevertCommitSmall(UICommands, selectedRevisions[0]);
                frm.ShowDialog(this);
            }
        }

        private void viewCommitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileChanges.ViewSelectedRevisions();
        }

        private const string FormBrowseName = "FormBrowse";

        public override void AddTranslationItems(Translation translation)
        {
            base.AddTranslationItems(translation);
            TranslationUtl.AddTranslationItemsFromFields(FormBrowseName, filterRevisionsHelper, translation);
            TranslationUtl.AddTranslationItemsFromFields(FormBrowseName, filterBranchHelper, translation);
        }

        public override void TranslateItems(Translation translation)
        {
            base.TranslateItems(translation);
            TranslationUtl.TranslateItemsFromFields(FormBrowseName, filterRevisionsHelper, translation);
            TranslationUtl.TranslateItemsFromFields(FormBrowseName, filterBranchHelper, translation);
        }

        private void diffToolremotelocalStripMenuItem_Click(object sender, EventArgs e)
        {
            FileChanges.OpenWithDifftool(FileName, string.Empty, GitUIExtensions.DiffWithRevisionKind.DiffBLocal);
        }

        private void toolStripSplitLoad_ButtonClick(object sender, EventArgs e)
        {
            LoadFileHistory();
        }

        private void loadHistoryOnShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.LoadFileHistoryOnShow = !Settings.LoadFileHistoryOnShow;
            loadHistoryOnShowToolStripMenuItem.Checked = Settings.LoadFileHistoryOnShow;
        }

        private void loadBlameOnShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.LoadBlameOnShow = !Settings.LoadBlameOnShow;
            loadBlameOnShowToolStripMenuItem.Checked = Settings.LoadBlameOnShow;
        }

        private void Blame_CommandClick(object sender, CommitInfo.CommandEventArgs e)
        {
            if (e.Command == "gotocommit")
            {
                FileChanges.SetSelectedRevision(new GitRevision(Module, e.Data));
            }
            else if (e.Command == "gotobranch" || e.Command == "gototag")
            {
                string error = "";
                CommitData commit = CommitData.GetCommitData(Module, e.Data, ref error);
                if (commit != null)
                    FileChanges.SetSelectedRevision(new GitRevision(Module, commit.Guid));
            }
        }
    }
}