using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saaty
{
    class TabManage
    {
        public int Index { get; set; }
        public int Size { get; set; }

        readonly TabControl tabControl;
        readonly Button buttonNext;
        readonly Button buttonBack;
        public TabManage(TabControl _tabControl, Button _next, Button _back)
        {
            Index = 0;
            Size = _tabControl.TabCount;

            tabControl = _tabControl;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;

            buttonNext = _next;
            buttonNext.Click += buttonNext_Click;

            buttonBack = _back;
            buttonBack.Click += buttonBack_Click;
            buttonBack.Enabled = false;
        }

        #region Manage

        public void SetIndex(int _index)
        {
            Index = _index;
            if (Index == Size - 1)
            {
                buttonBack.Enabled = true;
                buttonNext.Enabled = false;
                tabControl.SelectTab(Index);
            }
            else if (Index == 0)
            {
                buttonBack.Enabled = false;
                buttonNext.Enabled = true;
                tabControl.SelectTab(Index);
            }
            else
            {
                buttonBack.Enabled = true;
                buttonNext.Enabled = true;
                tabControl.SelectTab(Index);
            }

        }

        public void IndexChanged()
        {
            Index = int.Parse(tabControl.SelectedIndex.ToString());
            if (Index == Size - 1)
            {
                buttonBack.Enabled = true;
                buttonNext.Enabled = false;
                tabControl.SelectTab(Index);
            }
            else if (Index == 0)
            {
                buttonBack.Enabled = false;
                buttonNext.Enabled = true;
                tabControl.SelectTab(Index);
            }
            else
            {
                buttonBack.Enabled = true;
                buttonNext.Enabled = true;
                tabControl.SelectTab(Index);
            }

        }

        public void Next()
        {
            Index++;
            if (Index == Size - 1)
            {
                buttonBack.Enabled = true;
                buttonNext.Enabled = false;
                tabControl.SelectTab(Index);
            }
            else
            {
                buttonBack.Enabled = true;
                buttonNext.Enabled = true;
                tabControl.SelectTab(Index);
            }

        }

        public void Back()
        {
            Index--;
            if (Index == 0)
            {
                buttonBack.Enabled = false;
                buttonNext.Enabled = true;
                tabControl.SelectTab(Index);
            }
            else
            {
                buttonBack.Enabled = true;
                buttonNext.Enabled = true;
                tabControl.SelectTab(Index);
            }
        }

        #endregion

        #region Events

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexChanged();
        }

        #endregion;

    }
}
