using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Saaty
{
    public partial class FormMain : Form
    {
        DataSatty dataSatty;
        TabManage tabManage;
        OpenAndSave openAndSave;

        public FormMain()
        {
            InitializeComponent();
            dataSatty = new DataSatty();
            tabManage = new TabManage(tabControlMain, buttonNext, buttonBack);
            openAndSave = new OpenAndSave(dataSatty);
        }

        public void Save()
        {
            openAndSave.Save();
        }

        #region Menu Strip

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataSatty.Clear();
            tabManage.SetIndex(0);
            openAndSave.New();
            labelFileName.Text = fileMessage(openAndSave.GetFileName(), false);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataSatty = (DataSatty)openAndSave.Open();
            labelFileName.Text = fileMessage(openAndSave.GetFileName(), true);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAndSave.Save();
        }

        #endregion

        #region Start Tab

        private string fileMessage(string _fileName, bool open)
        {
            string fileMessageText = "";
            string openOrNew;
            if (open) openOrNew = "załadowany"; else openOrNew = "utworzony";
            if (_fileName != "")
            {
                fileMessageText += "Projekt został " + openOrNew + ".";
                fileMessageText += "\n\nTwoje postępy będą autoamtycznie zapisywane w pliku:\n";
                fileMessageText += openAndSave.GetFileName();
                fileMessageText += "\n\nMożesz spokojnie przejść dalej.";
                tabManage.HideTabs();
                tabManage.ShowTab(1);
            }
            else
            {
                fileMessageText += "Projekt nie został " + openOrNew + ".";
            }
            return fileMessageText;
        }

        private void buttonNewProject_Click(object sender, EventArgs e)
        {
            dataSatty.Clear();
            openAndSave.New();
            labelFileName.Text = fileMessage(openAndSave.GetFileName(), false);
        }

        private void buttonOpenProject_Click(object sender, EventArgs e)
        {
            dataSatty = (DataSatty)openAndSave.Open();
            labelFileName.Text = fileMessage(openAndSave.GetFileName(), true);
        }

        #endregion

        #region Step 1 Tab : Add Criteria

        public void tabPageStep1_Enter(object sender, EventArgs e)
        {
            dataGridViewCriteria.Rows.Clear();
            dataGridViewCriteria.Columns.Clear();
            dataGridViewCriteria.Columns.Add("name", "Nazwa");
            dataGridViewCriteria.Columns.Add("value", "Wartość");
            dataGridViewCriteria.Columns.Add("precision", "Dokładność");
            for (int i = 0; i < dataGridViewCriteria.Columns.Count; i++)
                dataGridViewCriteria.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            string value;
            for (int i = 0; i < dataSatty.ListCriteria.Count; i++)
            {
                if (dataSatty.ListCriteriaValueType[i]) value = "Im mniejsza tym lepiej";
                else value = "Im większa tym lepiej";
                dataGridViewCriteria.Rows.Add(dataSatty.ListCriteria[i], value, dataSatty.ListCriteriaPrecision[i]);
            }
            //if (dataSatty.ListCriteria.Count > 0) tabManage.ShowTab(2);
        }

        private void buttonAddCriteria_Click(object sender, EventArgs e)
        {
            FormCriteria formCriteria = new FormCriteria(dataSatty, this);
            formCriteria.Show();
        }

        private void buttonEditCriteria_Click(object sender, EventArgs e)
        {
            if (dataSatty.ListCriteria.Count != 0)
            {
                FormCriteria formCriteria = new FormCriteria(dataSatty, this, dataGridViewCriteria.SelectedRows[0].Index);
                formCriteria.Text = "Edytuj kryterium";
                formCriteria.Show();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataSatty.ListCriteria.Count == 1)
            {
                MessageBox.Show("Nie możesz usunąć wszystkich kryteriów.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataSatty.ListCriteria.Count == 0)
            {

            }
            else
            {
                dataSatty.RemoveCriteria(dataGridViewCriteria.SelectedRows[0].Index);
                tabPageStep1_Enter(sender, e);
                Save();
            }
        }

        #endregion

        #region Step 2 Tab : Wieght Criteria



        #endregion

        #region Results Tab

        private void buttonResults_Click(object sender, EventArgs e)
        {
            dataSatty.Calculate();
            MessageBox.Show(dataSatty.ResultName, "Wynik", MessageBoxButtons.OK);
        }

        #endregion

    }
}
