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
        TabControl tabControl;
        Button buttonNext;
        Button buttonBack;
        public TabManage(int _size, TabControl _tabControl, Button _next, Button _back)
        {
            Index = 0;
            Size = _size;
            tabControl = _tabControl;
            buttonNext = _next;
            buttonBack = _back;

            buttonBack.Enabled = false;
        }

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


    }
}
