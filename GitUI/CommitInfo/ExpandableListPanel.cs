using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GitCommands;

namespace GitUI.CommitInfo
{
    public partial class ExpandableListPanel : FlowLayoutPanel
    {
        private const int DefaultItemsToShow = 3;
        private readonly List<object> _items = new List<object>();
        private int _itemsToShow = DefaultItemsToShow;


        public ExpandableListPanel()
        {
            InitializeComponent();
            Controls.Clear();
        }

        [DefaultValue(DefaultItemsToShow)]
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
            //SuspendLayout();

            action?.Invoke();


            Control[] items = _items.Take(ItemsToShow).Select(CreateItem).ToArray();
            Controls.AddRange(items);
            if (_items.Count > ItemsToShow)
            {
                Controls.Add(itemMore);
            }

            //ResumeLayout(false);
            //PerformLayout();
        }

        private Control CreateItem(object item)
        {
            var c = new LinkLabel
            {
                AutoSize = true,
                //BorderStyle = BorderStyle.FixedSingle,
                Font = AppSettings.Font,
                LinkColor = SystemColors.HotTrack,
                Margin = new Padding(0),
                Text = item.ToString()
            };
            return c;
        }


        private void itemMore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Controls.Remove(itemMore);
            Control[] items = _items.Skip(ItemsToShow).Select(CreateItem).ToArray();
            Controls.AddRange(items);
        }
    }
}
