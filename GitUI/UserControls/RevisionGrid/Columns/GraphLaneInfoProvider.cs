using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using GitUI.UserControls.RevisionGrid.Graph;
using JetBrains.Annotations;

namespace GitUI.UserControls.RevisionGrid.Columns
{
    internal sealed class GraphLaneInfoProvider
    {
        private readonly GraphModel _graphModel;

        public GraphLaneInfoProvider(GraphModel graphModel)
        {
            _graphModel = graphModel;
        }

        public string GetLaneInfo(int x, int rowIndex)
        {
            var lane = x / GraphColumnProvider.LaneWidth;
            var laneInfoText = new StringBuilder();
            lock (_graphModel)
            {
                var laneRow = _graphModel.GetLaneRow(rowIndex);
                if (laneRow == null)
                {
                    return laneInfoText.ToString();
                }

                Node node = null;
                if (lane == laneRow.NodeLane)
                {
                    node = laneRow.Node;
                    if (!node.Revision.IsArtificial)
                    {
                        laneInfoText.Append("* ");
                    }
                }
                else if (lane >= 0 && lane < laneRow.Count)
                {
                    var laneInfoIndex = 0;
                    while (laneInfoIndex < laneRow.LaneInfoCount(lane))
                    {
                        // search for next node below this row
                        var laneInfo = laneRow[lane, laneInfoIndex];
                        var firstJunction = laneInfo.Junctions.First();
                        for (int nodeIndex = 0, nodeCount = firstJunction.NodeCount; nodeIndex < nodeCount; ++nodeIndex)
                        {
                            var laneNode = firstJunction[nodeIndex];
                            if (laneNode.Index <= rowIndex)
                            {
                                continue;
                            }

                            node = laneNode;
                            break; // from for (nodes)
                        }

                        ++laneInfoIndex;
                    }
                }

                if (node == null)
                {
                    return laneInfoText.ToString();
                }

                if (!node.Revision.IsArtificial)
                {
                    laneInfoText.AppendLine(node.Revision.Guid);

                    var references = new References(node);
                    if (references.CommittedTo.IsNotNullOrWhitespace())
                    {
                        laneInfoText.AppendFormat("\nBranch: {0}", references.CommittedTo);
                        if (references.MergedWith.IsNotNullOrWhitespace())
                        {
                            laneInfoText.AppendFormat(" (merged with {0})", references.MergedWith);
                        }
                    }

                    laneInfoText.AppendLine().AppendLine();
                }

                if (node.Revision.Body != null)
                {
                    laneInfoText.Append(node.Revision.Body.TrimEnd());
                }
                else
                {
                    laneInfoText.Append(node.Revision.Subject);
                    if (node.Revision.HasMultiLineMessage)
                    {
                        laneInfoText.Append("\n\nFull message text is not present in older commits.\nSelect this commit to populate the full message.");
                    }
                }
            }

            return laneInfoText.ToString();
        }

        private class References
        {
            private readonly HashSet<Node> _visitedNodes = new HashSet<Node>();
            private static readonly Regex _merge = new Regex("(?i)^merged? (pull request (.*) from )?(.*branch )?'?([^ ']+)'?( into (.*))?\\.?$");

            internal References([NotNull] Node node)
            {
                AddReferencesOf(node, previousDescJunction: null);
            }

            internal string CommittedTo { get; private set; }
            internal string MergedWith { get; private set; }

            private bool AddReferencesOf([NotNull] Node node, [CanBeNull] Junction previousDescJunction)
            {
                if (_visitedNodes.Add(node))
                {
                    if (CheckForMerge(node, previousDescJunction) || FindBranch(node, node, previousDescJunction))
                    {
                        return true;
                    }

                    foreach (var descJunction in node.Descendants)
                    {
                        // iterate the inner nodes (i.e. excluding the youngest) beginning with the oldest
                        var nodeFound = false;
                        for (var nodeIndex = descJunction.NodeCount - 1; nodeIndex > 0; --nodeIndex)
                        {
                            var innerNode = descJunction[nodeIndex];
                            if (nodeFound)
                            {
                                if (FindBranch(innerNode, node, descJunction))
                                {
                                    return true;
                                }
                            }
                            else
                            {
                                nodeFound = innerNode == node;
                            }
                        }

                        // handle the youngest and its descendants
                        if (AddReferencesOf(descJunction.Youngest, descJunction))
                        {
                            return true;
                        }
                    }
                }

                return false;
            }

            private bool FindBranch([NotNull] Node descNode, [NotNull] Node node, [CanBeNull] Junction descJunction)
            {
                foreach (var gitReference in descNode.Revision.Refs)
                {
                    if (gitReference.IsHead || gitReference.IsRemote)
                    {
                        CheckForMerge(node, descJunction);
                        CommittedTo = CommittedTo ?? gitReference.Name;
                        return true;
                    }
                    else if (gitReference.IsStash && CommittedTo == null)
                    {
                        CommittedTo = gitReference.Name;
                        return true;
                    }
                }

                return false;
            }

            /// <summary>
            /// Checks whether the commit message is a merge message
            /// and then if its a merge message, sets CommittedTo and MergedWith.
            ///
            /// MergedWith is set if it is the current node, i.e. on the first call.
            /// MergedWith is set to string.Empty if it is no merge.
            /// First/second branch does not matter because it is the message of the current node.
            /// </summary>
            /// <param name="node">the node of the revision to evaluate</param>
            /// <param name="descJunction">
            /// the descending junction the node is part of
            /// (used for the decision whether the node belongs the first or second branch of the merge)
            /// </param>
            private bool CheckForMerge([NotNull] Node node, [CanBeNull] Junction descJunction)
            {
                var isTheFirstBranch = descJunction == null || node.Ancestors.Count == 0 || node.Ancestors.First() == descJunction;
                string mergedInto;
                string mergedWith;
                (mergedInto, mergedWith) = ParseMergeMessage(node, isTheFirstBranch);

                if (mergedInto != null)
                {
                    CommittedTo = isTheFirstBranch ? mergedInto : mergedWith;
                }

                if (MergedWith == null)
                {
                    MergedWith = mergedWith ?? string.Empty;
                }

                return CommittedTo != null;
            }

            private static (string into, string with) ParseMergeMessage([NotNull] Node node, bool appendPullRequest)
            {
                string into = null;
                string with = null;
                var match = _merge.Match(node.Revision.Subject);
                if (match.Success)
                {
                    var matchPullRequest = match.Groups[2];
                    var matchWith = match.Groups[4];
                    var matchInto = match.Groups[6];
                    into = matchInto.Success ? matchInto.Value : "master";
                    with = matchWith.Success ? matchWith.Value : "?";
                    if (appendPullRequest && matchPullRequest.Success)
                    {
                        with += string.Format(" by pull request {0}", matchPullRequest);
                    }
                }

                return (into, with);
            }
        }
    }
}