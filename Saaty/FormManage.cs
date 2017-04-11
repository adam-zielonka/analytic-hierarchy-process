using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saaty
{
    public partial class FormManage : Form
    {
        DataSatty dataSatty;
        List<TextBox> listTextBox;
        List<Button> listButtonDel;
        Button button;
        bool alternative;

        public FormManage(DataSatty _dataSatty,Button _button, bool _alternative = false)
        {
            InitializeComponent();
            dataSatty = _dataSatty;
            listTextBox = new List<TextBox>();
            listButtonDel = new List<Button>();
            alternative = _alternative;
            button = _button;
            _button.Enabled = false;
            if (alternative)
                LoadList(dataSatty.ListAlternative);
            else
                LoadList(dataSatty.ListCriteria);
        }

        private void LoadList(List<string> _list)
        {
            for (int i = 0; i < listTextBox.Count; i++)
            {
                Controls.Remove(listTextBox[i]);
                Controls.Remove(listButtonDel[i]);
            }
            listTextBox.Clear();
            listButtonDel.Clear();
            for (int i = 0; i < _list.Count; i++)
            {
                listTextBox.Add(new TextBox());
                listTextBox[listTextBox.Count - 1].Location = new Point(53, 37 + 25 * (listTextBox.Count - 1));
                listTextBox[listTextBox.Count - 1].Size = new Size(360, 20);
                listTextBox[listTextBox.Count - 1].Text = _list[i];
                listTextBox[listTextBox.Count - 1].Enabled = false;
                Controls.Add(listTextBox[listTextBox.Count - 1]);

                listButtonDel.Add(new Button());
                listButtonDel[listButtonDel.Count - 1].Location = new Point(419, 35 + 25 * (listButtonDel.Count - 1));
                listButtonDel[listButtonDel.Count - 1].Size = new Size(75, 23);
                listButtonDel[listButtonDel.Count - 1].Text = "Usuń";
                listButtonDel[listButtonDel.Count - 1].Click += new EventHandler(listButtonDel_Click);
                Controls.Add(listButtonDel[listButtonDel.Count - 1]);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxAdd.Text != "")
            {
                if (alternative)
                {
                    dataSatty.AddAlternative(textBoxAdd.Text);
                    textBoxAdd.Text = "";
                    LoadList(dataSatty.ListAlternative);
                }
                else
                {
                    dataSatty.AddCriteria(textBoxAdd.Text);
                    textBoxAdd.Text = "";
                    LoadList(dataSatty.ListCriteria);
                }
            }
        }

        private void textBoxAdd_Enter(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = buttonAdd;
        }

        private void listButtonDel_Click(object sender, EventArgs e)
        {
            Button buttonDel = (Button)sender;
            Point point = buttonDel.Location;
            if (alternative)
            {
                dataSatty.RemoveAlternative((point.Y - 35) / 25);
                LoadList(dataSatty.ListAlternative);
            }
            else
            {
                dataSatty.RemoveCriteria((point.Y - 35) / 25);
                LoadList(dataSatty.ListCriteria);
            }
            
        }

        private void FormManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            button.Enabled = true;
        }
    }
}
