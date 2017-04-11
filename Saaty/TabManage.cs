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

        readonly TabControl tabControl;
        readonly Button buttonNext;
        readonly Button buttonBack;

        List<TabPage> listPage;
        List<bool> listPageStatus;
        public TabManage(TabControl _tabControl, Button _next, Button _back)
        {
            Index = 0;
            tabControl = _tabControl;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;

            buttonNext = _next;
            buttonNext.Click += buttonNext_Click;

            buttonBack = _back;
            buttonBack.Click += buttonBack_Click;

            listPage = new List<TabPage>();
            listPageStatus = new List<bool>();
            for (int i = 0; i < _tabControl.TabCount; i++)
            {
                listPage.Add(tabControl.TabPages[i]);
                listPageStatus.Add(false);
            }
            tabControl.TabPages.Clear();
            ShowTab(0);
        }

        #region Hide Show Tab

        public void HideTabs()
        {
            Index = 0;
            for (int i = 1; i < listPage.Count; i++)
            {
                HideTab(i);
            }
        }

        public void ShowTab(int id)
        {
            if (!listPageStatus[id])
            {
                tabControl.TabPages.Add(listPage[id]);
                listPageStatus[id] = true;
                SetIndex(Index);
            }
        }

        public void HideTab(int id)
        {
            if (listPageStatus[id])
            {
                tabControl.TabPages.Remove(listPage[id]);
                listPageStatus[id] = false;
                SetIndex(Index);
            }
        }

        #endregion

        #region Manage

        public void SetIndex(int _index)
        {
            Index = _index;
            buttonBack.Enabled = true;
            buttonNext.Enabled = true;

            if (Index == tabControl.TabCount - 1)
            {
                buttonNext.Enabled = false;
            }
            if (Index == 0)
            {
                buttonBack.Enabled = false;
            }
            tabControl.SelectTab(Index);

        }

        public void IndexChanged()
        {
            Index = int.Parse(tabControl.SelectedIndex.ToString());
            buttonBack.Enabled = true;
            buttonNext.Enabled = true;

            if (Index == tabControl.TabCount - 1)
            {
                buttonNext.Enabled = false;
            }
            if (Index == 0)
            {
                buttonBack.Enabled = false;
            }
        }

        public void Next()
        {
            Index++;
            if (Index == tabControl.TabCount - 1)
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
