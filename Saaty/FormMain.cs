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
            for (int i = 0; i < dataSatty.criteria.Name.Count; i++)
            {
                if (dataSatty.criteria.ValueType[i]) value = "Im mniejsza tym lepiej";
                else value = "Im większa tym lepiej";
                dataGridViewCriteria.Rows.Add(dataSatty.criteria.Name[i], value, dataSatty.criteria.Precision[i]);
            }
            if (dataGridViewCriteria.Rows.Count > 0)
            {
                if (tabManage.Index == 0) tabManage.SetIndex(1);
                tabManage.ShowTab(2);
                tabManage.ShowTab(3);
            }
        }

        private void buttonAddCriteria_Click(object sender, EventArgs e)
        {
            FormCriteria formCriteria = new FormCriteria(dataSatty, this);
            formCriteria.Show();
        }

        private void buttonEditCriteria_Click(object sender, EventArgs e)
        {
            if (dataSatty.criteria.Name.Count != 0)
            {
                FormCriteria formCriteria = new FormCriteria(dataSatty, this, dataGridViewCriteria.SelectedRows[0].Index);
                formCriteria.Text = "Edytuj kryterium";
                formCriteria.Show();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataSatty.criteria.Name.Count == 1)
            {
                MessageBox.Show("Nie możesz usunąć wszystkich kryteriów.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataSatty.criteria.Name.Count == 0)
            {

            }
            else
            {
                int id = dataGridViewCriteria.SelectedRows[0].Index;
                dataSatty.RemoveCriteria(id);
                id--;
                tabPageStep1_Enter(sender, e);
                if (id > 0) dataGridViewCriteria.Rows[id].Selected = true;
                Save();
            }
        }

        #endregion

        #region Step 2 Tab : Wieght Criteria

        private void tabPageStep2_Enter(object sender, EventArgs e)
        {
            dataGridViewCriteriaWeight.Rows.Clear();
            dataGridViewCriteriaWeight.Columns.Clear();
            dataGridViewCriteriaWeight.Columns.Add("id", "ID");
            dataGridViewCriteriaWeight.Columns.Add("name", "Nazwa");
            dataGridViewCriteriaWeight.Columns.Add("wight", "Ważność");
            dataGridViewCriteriaWeight.Columns.Add("wightInt", "Ważność");
            dataGridViewCriteriaWeight.Columns[0].Visible = false;
            dataGridViewCriteriaWeight.Columns[3].Visible = false;
            for (int i = 0; i < dataGridViewCriteriaWeight.Columns.Count; i++)
                dataGridViewCriteriaWeight.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            for (int i = 0; i < dataSatty.criteria.Name.Count; i++)
            {
                string weight = "";
                if (dataSatty.criteria.Weight[i] > 0) weight += dataSatty.criteria.Weight[i];
                else weight += "1/" + Math.Abs(dataSatty.criteria.Weight[i]);
                dataGridViewCriteriaWeight.Rows.Add(i, dataSatty.criteria.Name[i], weight, dataSatty.criteria.Weight[i]);
            }
            dataGridViewCriteriaWeight.Sort(dataGridViewCriteriaWeight.Columns[3], ListSortDirection.Descending);
        }

        private void buttonUpCriteria_Click(object sender, EventArgs e)
        {
            if (dataGridViewCriteriaWeight.Rows.Count != 0)
            {
                int id = int.Parse(dataGridViewCriteriaWeight.Rows[dataGridViewCriteriaWeight.SelectedRows[0].Index].Cells[0].Value.ToString());
                dataSatty.UpCriteria(id);
                tabPageStep2_Enter(sender, e);
                for (int i = 0; i < dataGridViewCriteriaWeight.RowCount; i++)
                {
                    if (int.Parse(dataGridViewCriteriaWeight.Rows[i].Cells[0].Value.ToString()) == id)
                    {
                        dataGridViewCriteriaWeight.Rows[i].Selected = true;
                        break;
                    }
                }
                Save();
            }
        }

        private void buttonDownCriteria_Click(object sender, EventArgs e)
        {
            if (dataGridViewCriteriaWeight.Rows.Count != 0)
            {
                int id = int.Parse(dataGridViewCriteriaWeight.Rows[dataGridViewCriteriaWeight.SelectedRows[0].Index].Cells[0].Value.ToString());
                dataSatty.DownCriteria(id);
                tabPageStep2_Enter(sender, e);
                for (int i = 0; i < dataGridViewCriteriaWeight.RowCount; i++)
                {
                    if (int.Parse(dataGridViewCriteriaWeight.Rows[i].Cells[0].Value.ToString()) == id)
                    {
                        dataGridViewCriteriaWeight.Rows[i].Selected = true;
                        break;
                    }
                }
                Save();
            }
        }

        private void buttonMatrix_Click(object sender, EventArgs e)
        {
            dataSatty.ZeroMatrix();
            dataSatty.GenerateMatrix();
            FormMatrix formMatrix = new FormMatrix(dataSatty);
            formMatrix.Show();
        }

        #endregion

        #region Step 3: 

        private void tabPageStep3_Enter(object sender, EventArgs e)
        {
            dataGridViewAlternative.Rows.Clear();
            dataGridViewAlternative.Columns.Clear();

            for (int i = 0; i < dataSatty.criteria.Name.Count; i++)
            {
                dataGridViewAlternative.Columns.Add(dataSatty.criteria.Name[i], dataSatty.criteria.Name[i]);
            }

            for (int j = 0; j < dataSatty.alternative.Name.Count; j++)
            {
                dataGridViewAlternative.Rows.Add();
                dataGridViewAlternative.Rows[j].HeaderCell.Value = dataSatty.alternative.Name[j];
            }
        }

        #endregion


        #region Results Tab

        private void buttonResults_Click(object sender, EventArgs e)
        {
            dataSatty.Calculate();
            MessageBox.Show(dataSatty.result.Name, "Wynik", MessageBoxButtons.OK);
        }


        #endregion


    }
}
