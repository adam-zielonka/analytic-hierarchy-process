using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Saaty
{
    public class TabManageClass
    {
        public int Index { get; set; }

        TabControl tabControl;
        Button buttonNext;
        Button buttonBack;

        List<TabPage> listPage;
        List<bool> listPageStatus;
        public TabManageClass(TabControl tabControl, Button next, Button back)
        {
            Index = 0;
            this.tabControl = tabControl;
            this.tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;

            buttonNext = next;
            buttonNext.Click += buttonNext_Click;

            buttonBack = back;
            buttonBack.Click += buttonBack_Click;

            listPage = new List<TabPage>();
            listPageStatus = new List<bool>();
            for (int i = 0; i < tabControl.TabCount; i++)
            {
                listPage.Add(this.tabControl.TabPages[i]);
                listPageStatus.Add(false);
            }
            this.tabControl.TabPages.Clear();
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

        public void ShowTab(int id,int idSelectedTab)
        {
            if (!listPageStatus[id])
            {
                tabControl.TabPages.Add(listPage[id]);
                listPageStatus[id] = true;
                SetIndex(idSelectedTab);
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

        public void HideTab(int id, int idSelectedTab)
        {
            if (listPageStatus[id])
            {
                tabControl.TabPages.Remove(listPage[id]);
                listPageStatus[id] = false;
                SetIndex(idSelectedTab);
            }
        }

        #endregion

        #region Manage

        public void SetIndex(int index)
        {
            Index = index;
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
