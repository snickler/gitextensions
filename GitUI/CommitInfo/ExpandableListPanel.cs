using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GitCommands;

namespace GitUI.CommitInfo
{
    public partial class ExpandableListPanel : FlowLayoutPanel
    {
        private readonly List<object> _items = new List<object>();
        //private string _displayMember;
        private int _itemsToShow = 3;


        public ExpandableListPanel()
        {
            InitializeComponent();
            this.Controls.Clear();
        }

        //public string DisplayMember
        //{
        //    get { return _displayMember; }
        //    set
        //    {
        //        _displayMember = value;
        //        Invalidate();
        //    }
        //}

        [DefaultValue(3)]
        public int ItemsToShow
        {
            get { return _itemsToShow; }
            set
            {
                if (value < 1)
                {
                    value = 1;
                }
                if (_itemsToShow == value)
                {
                    return;
                }
                _itemsToShow = value;
                Invalidate();
            }
        }


        public void AddRange(IEnumerable<object> items)
        {
            Render(() =>
            {
                _items.Clear();
                Controls.Clear();
                if (items != null)
                {
                    _items.AddRange(items.Where(i => i != null));
                }
            });
        }

        public void Render()
        {
            Render(null);
        }


        private void Render(Action action)
        {
            SuspendLayout();

            action?.Invoke();

            _items.Take(ItemsToShow).ForEach(AddItem);
            if (_items.Count > ItemsToShow)
            {
                Controls.Add(itemMore);
            }

            ResumeLayout(false);
            PerformLayout();
        }

        private void AddItem(object item)
        {
            if (item == null)
            {
                return;
            }

            var c = new LinkLabel
            {
                AutoSize = true,
                //BorderStyle = BorderStyle.FixedSingle,
                Font = AppSettings.Font, //new Font(AppSettings.Font.FontFamily, AppSettings.Font.SizeInPoints - 1),
                LinkColor = SystemColors.HotTrack,
                Margin = new Padding(0),
                Text = item.ToString()
            };

            //else if (!string.IsNullOrWhiteSpace(_displayMember) && )
            //{
            //}

            Controls.Add(c);
        }


        private void itemMore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Controls.Remove(itemMore);
            _items.Skip(ItemsToShow).ForEach(AddItem);
        }
    }
}
