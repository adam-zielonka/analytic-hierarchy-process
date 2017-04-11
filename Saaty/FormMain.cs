using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Saaty
{

    public partial class FormMain : Form
    {
        DataSatty dataSatty;
        TabManage tabManage;

        List<TextBox> listTextBoxCriteria;
        List<TextBox> listTextBoxAlternative;
        List<Button> listButtonDelCriteria;
        List<Button> listButtonDelAlternative;
        public FormMain()
        {
            InitializeComponent();
            dataSatty = new DataSatty();
            tabManage = new TabManage(6, tabControl, buttonNext, buttonBack);
            listTextBoxCriteria = new List<TextBox>();
            listTextBoxAlternative = new List<TextBox>();
            listButtonDelCriteria = new List<Button>();
            listButtonDelAlternative = new List<Button>();
        }

        private void LoadData()
        {
            LoadList(dataSatty.ListCriteria, tabPageCriteria, listButtonDelCriteria, listTextBoxCriteria);
            LoadList(dataSatty.ListAlternative, tabPageAlternative, listButtonDelAlternative, listTextBoxAlternative, false);
        }

        #region Strip Menu

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Analytic Hierarchy Process File|*.ahp";
            saveFileDialog.Title = "Zapisz projekt do pliku";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                XmlSerializer writer = new XmlSerializer(typeof(DataSatty));
                StreamWriter file = new StreamWriter(saveFileDialog.FileName);
                writer.Serialize(file, dataSatty);
                file.Close();
            }
            LoadData();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Analytic Hierarchy Process File|*.ahp";
            openFileDialog.Title = "Otwórz projekt z pliku";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                XmlSerializer serializer = new XmlSerializer(typeof(DataSatty));
                StreamReader reader = new StreamReader(openFileDialog.FileName);
                dataSatty = (DataSatty)serializer.Deserialize(reader);
                reader.Close();
            }
            LoadData();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataSatty.Clear();
            LoadData();
        }

        #endregion

        #region Language Settings

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            Controls.Clear();
            InitializeComponent();
        }

        private void polishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pl");
            Controls.Clear();
            InitializeComponent();
        }

        #endregion

        #region Start Tab

        private void buttonWeightCriteria_Click(object sender, EventArgs e)
        {
            FormWeight formWeight = new FormWeight(dataSatty.ListCriteria, dataSatty.MatrixCriteria);
            formWeight.Show();
        }

        private void buttonMatrixWeight_Click(object sender, EventArgs e)
        {
            FormMatrix formMatrix = new FormMatrix(dataSatty.ListCriteria, dataSatty.MatrixCriteria);
            formMatrix.Show();
        }

        private void buttonWeightAlternative_Click(object sender, EventArgs e)
        {
            FormWeight formWeight = new FormWeight(dataSatty.ListCriteria, dataSatty.ListAlternative, dataSatty.MatrixAlternative);
            formWeight.Show();
        }

        private void buttonMatrixWeightAlternative_Click(object sender, EventArgs e)
        {
            FormMatrix formMatrix = new FormMatrix(dataSatty.ListCriteria, dataSatty.ListAlternative, dataSatty.MatrixAlternative);
            formMatrix.Show();
        }
        #endregion

        #region TabsAddDel

        private void LoadList(List<string> _list, TabPage _tabPage, List<Button> _listButtonDel, List<TextBox> _listTextBox, bool _criteria = true)
        {
            for (int i = 0; i < _listTextBox.Count; i++)
            {
                _tabPage.Controls.Remove(_listTextBox[i]);
                _tabPage.Controls.Remove(_listButtonDel[i]);
            }
            _listTextBox.Clear();
            _listButtonDel.Clear();
            for (int i = 0; i < _list.Count; i++)
            {
                _listTextBox.Add(new TextBox());
                _listTextBox[_listTextBox.Count - 1].Location = new Point(53, 37 + 25 * (_listTextBox.Count - 1));
                _listTextBox[_listTextBox.Count - 1].Size = new Size(360, 20);
                _listTextBox[_listTextBox.Count - 1].Text = _list[i];
                _listTextBox[_listTextBox.Count - 1].Enabled = false;
                _tabPage.Controls.Add(_listTextBox[_listTextBox.Count - 1]);

                _listButtonDel.Add(new Button());
                _listButtonDel[_listButtonDel.Count - 1].Location = new Point(419, 35 + 25 * (_listButtonDel.Count - 1));
                _listButtonDel[_listButtonDel.Count - 1].Size = new Size(75, 23);
                _listButtonDel[_listButtonDel.Count - 1].Text = "Usuń";
                if (_criteria)
                    _listButtonDel[_listButtonDel.Count - 1].Click += new EventHandler(listButtonDelCriteria_Click);
                else
                    _listButtonDel[_listButtonDel.Count - 1].Click += new EventHandler(listButtonDelAlternative_Click);
                _tabPage.Controls.Add(_listButtonDel[_listButtonDel.Count - 1]);
            }
        }

        private void buttonAddCriteria_Click(object sender, EventArgs e)
        {
            if (textBoxAddCriteria.Text != "")
            {
                dataSatty.AddCriteria(textBoxAddCriteria.Text);
                textBoxAddCriteria.Text = "";
                LoadList(dataSatty.ListCriteria, tabPageCriteria, listButtonDelCriteria, listTextBoxCriteria);
            }
        }

        private void buttonAddAlternative_Click(object sender, EventArgs e)
        {
            if (textBoxAddAlternative.Text != "")
            {
                dataSatty.AddAlternative(textBoxAddAlternative.Text);
                textBoxAddAlternative.Text = "";
                LoadList(dataSatty.ListAlternative, tabPageAlternative, listButtonDelAlternative, listTextBoxAlternative, false);
            }
        }

        private void textBoxAddCriteria_Enter(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = buttonAddCriteria;
        }

        private void textBoxAddAlternative_Enter(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = buttonAddAlternative;
        }

        private void listButtonDelCriteria_Click(object sender, EventArgs e)
        {
            Button buttonDel = (Button)sender;
            Point point = buttonDel.Location;

            dataSatty.RemoveCriteria((point.Y - 35) / 25);
            LoadList(dataSatty.ListCriteria, tabPageCriteria, listButtonDelCriteria, listTextBoxCriteria);
        }

        private void listButtonDelAlternative_Click(object sender, EventArgs e)
        {
            Button buttonDel = (Button)sender;
            Point point = buttonDel.Location;

            dataSatty.RemoveAlternative((point.Y - 35) / 25);
            LoadList(dataSatty.ListAlternative, tabPageAlternative, listButtonDelAlternative, listTextBoxAlternative, false);
        }


        #endregion

        #region ManageTab
        private void buttonNext_Click(object sender, EventArgs e)
        {
            tabManage.Next();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            tabManage.Back();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabManage.IndexChanged();
        }

        #endregion

        private void buttonResults_Click(object sender, EventArgs e)
        {
            int id = dataSatty.Calculate();
            MessageBox.Show(dataSatty.ListAlternative[id], "Wynik", MessageBoxButtons.OK);
        }
    }

    public class TabManage
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
