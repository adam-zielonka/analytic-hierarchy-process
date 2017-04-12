using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Saaty
{
    public partial class FormMain : Form
    {
        public SaatyClass Saaty { get; set; }
        public TabManageClass TabManage { get; set; }
        public FileManageClass FileManage { get; set; }

        public FormMain()
        {
            InitializeComponent();
            Saaty = new SaatyClass();
            TabManage = new TabManageClass(tabControlMain, buttonNext, buttonBack);
            FileManage = new FileManageClass(Saaty);
        }

        public void Save() => FileManage.Save();

        #region Menu Strip

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saaty.Clear();
            TabManage.SetIndex(0);
            FileManage.New();
            labelFileName.Text = FileMessage(FileManage.GetFileName(), false);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saaty = (SaatyClass)FileManage.Open();
            labelFileName.Text = FileMessage(FileManage.GetFileName(), true);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManage.Save();
        }

        #endregion

        #region Start Tab

        private string FileMessage(string fileName, bool open)
        {
            string fileMessageText = "";
            string openOrNew = open ? "załadowany" : "utworzony";
            if (fileName != "")
            {
                fileMessageText += "Projekt został " + openOrNew + ".";
                fileMessageText += "\n\nTwoje postępy będą autoamtycznie zapisywane w pliku:\n";
                fileMessageText += FileManage.GetFileName();
                fileMessageText += "\n\nMożesz spokojnie przejść dalej.";
                TabManage.HideTabs();
                TabManage.ShowTab(1);
            }
            else
            {
                fileMessageText += "Projekt nie został " + openOrNew + ".";
            }
            return fileMessageText;
        }

        private void buttonNewProject_Click(object sender, EventArgs e)
        {
            Saaty.Clear();
            FileManage.New();
            labelFileName.Text = FileMessage(FileManage.GetFileName(), false);
        }

        private void buttonOpenProject_Click(object sender, EventArgs e)
        {
            Saaty = (SaatyClass)FileManage.Open();
            labelFileName.Text = FileMessage(FileManage.GetFileName(), true);
        }

        #endregion

        #region Step 1 Tab : Add Criteria

        public void tabPageStep1_Enter(object sender, EventArgs e)
        {
            dataGridViewCriteria.Rows.Clear();
            dataGridViewCriteria.Columns.Clear();
            dataGridViewCriteria.Columns.Add("name", "Nazwa");
            dataGridViewCriteria.Columns.Add("value", "Wartość");
            for (int i = 0; i < dataGridViewCriteria.Columns.Count; i++)
                dataGridViewCriteria.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            for (int i = 0; i < Saaty.Criteria.Count; i++)
            {
                string value = Saaty.Criteria.ValueType[i] ? "Im mniejsza tym lepiej" : "Im większa tym lepiej";
                dataGridViewCriteria.Rows.Add(Saaty.Criteria.Name[i], value);
            }
            if (dataGridViewCriteria.Rows.Count > 0)
            {
                TabManage.ShowTab(2, 1);
            }
        }

        private void buttonAddCriteria_Click(object sender, EventArgs e)
        {
            FormCriteria formCriteria = new FormCriteria(Saaty, this);
            formCriteria.Show();
        }

        private void buttonEditCriteria_Click(object sender, EventArgs e)
        {
            if (Saaty.Criteria.Count != 0)
            {
                FormCriteria formCriteria = new FormCriteria(Saaty, this, dataGridViewCriteria.SelectedRows[0].Index)
                {
                    Text = @"Edytuj kryterium"
                };
                formCriteria.Show();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            switch (Saaty.Criteria.Count)
            {
                case 1:
                    MessageBox.Show(@"Nie możesz usunąć wszystkich kryteriów.", @"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 0:
                    break;
                default:
                    int id = dataGridViewCriteria.SelectedRows[0].Index;
                    Saaty.RemoveCriteria(id);
                    id--;
                    tabPageStep1_Enter(sender, e);
                    if (id > 0) dataGridViewCriteria.Rows[id].Selected = true;
                    Save();
                    break;
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
            dataGridViewCriteriaWeight.Columns[0].Visible = false;
            for (int i = 0; i < dataGridViewCriteriaWeight.Columns.Count; i++)
                dataGridViewCriteriaWeight.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            for (int i = 0; i < Saaty.Criteria.Count; i++)
                dataGridViewCriteriaWeight.Rows.Add(i, Saaty.Criteria.Name[i], Saaty.Criteria.Weight[i]);
            dataGridViewCriteriaWeight.Sort(dataGridViewCriteriaWeight.Columns[2], ListSortDirection.Descending);
            TabManage.ShowTab(3, 2);
        }

        private void buttonUpCriteria_Click(object sender, EventArgs e)
        {
            if (dataGridViewCriteriaWeight.Rows.Count != 0)
            {
                int id = int.Parse(dataGridViewCriteriaWeight.Rows[dataGridViewCriteriaWeight.SelectedRows[0].Index].Cells[0].Value.ToString());
                Saaty.UpCriteria(id);
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
                Saaty.DownCriteria(id);
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
            Saaty.ZeroMatrix();
            Saaty.GenerateMatrixCriteria();
            FormMatrix formMatrix = new FormMatrix(Saaty)
            {
                Text = @"Macierz Kryteriów"
            };
            formMatrix.Show();
        }

        #endregion

        #region Step 3 Tab : Add Alternative 

        public void tabPageStep3_Enter(object sender, EventArgs e)
        {
            dataGridViewAlternative.Rows.Clear();
            dataGridViewAlternative.Columns.Clear();
            dataGridViewAlternative.Columns.Add("name", "Nazwa");
            dataGridViewAlternative.Columns.Add("status", "Stan");
            dataGridViewCriteria.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            string status = @"OK";
            bool error = false;
            for (int j = 0; j < Saaty.Alternative.Count; j++)
            {
                status = @"OK";
                for (int i = 0; i < Saaty.Criteria.Count; i++)
                {
                    if (Saaty.Matrix.Data[i][j] == double.MaxValue)
                    {
                        status = @"Nie wszystkie dane są uzupełnione";
                        error = true;
                    }
                }
                dataGridViewAlternative.Rows.Add(Saaty.Alternative.Name[j], status);
            }
            if (dataGridViewAlternative.Rows.Count > 0 && error == false)
            {
                TabManage.ShowTab(4, 3);
            }
            else
            {
                TabManage.HideTab(4, 3);
            }
        }

        private void buttonAddAlternative_Click(object sender, EventArgs e)
        {
            FormAlternative formAlternative = new FormAlternative(Saaty, this);
            formAlternative.Show();
        }

        private void buttonEditAlternative_Click(object sender, EventArgs e)
        {
            if (Saaty.Alternative.Count != 0)
            {
                FormAlternative formAlternative = new FormAlternative(Saaty, this, dataGridViewAlternative.SelectedRows[0].Index)
                {
                    Text = @"Edytuj alternatywę"
                };
                formAlternative.Show();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            int id;
            switch (Saaty.Alternative.Count)
            {
                case 1:
                    id = dataGridViewAlternative.SelectedRows[0].Index;
                    Saaty.RemoveAlternative(id);
                    TabManage.HideTab(4);
                    tabPageStep3_Enter(sender, e);
                    Save();
                    break;
                case 0:
                    break;
                default:
                    id = dataGridViewAlternative.SelectedRows[0].Index;
                    Saaty.RemoveAlternative(id);
                    id--;
                    tabPageStep3_Enter(sender, e);
                    if (id > 0) dataGridViewAlternative.Rows[id].Selected = true;
                    Save();
                    break;
            }
        }

        private void buttonMatrixAlternative_Click(object sender, EventArgs e)
        {
            Saaty.ZeroMatrix();
            Saaty.GenerateMatrixAlternative();
            FormMatrix formMatrix = new FormMatrix(Saaty, true)
            {
                Text = @"Macierze Alternatyw"
            };
            formMatrix.Show();
        }

        private void buttonDataAlternative_Click(object sender, EventArgs e)
        {
            FormMatrix formMatrix = new FormMatrix(Saaty, 123)
            {
                Text = @"Dane Alternatyw"
            };

            formMatrix.Show();
        }

        #endregion

        #region Results Tab

        private void tabPageResults_Enter(object sender, EventArgs e)
        {
            Saaty.ZeroMatrix();
            Saaty.GenerateMatrixCriteria();
            Saaty.GenerateMatrixAlternative();
            Saaty.Calculate();
            Save();

            dataGridViewResults.Rows.Clear();
            dataGridViewResults.Columns.Clear();
            dataGridViewResults.Columns.Add("name", "Nazwa");
            dataGridViewResults.Columns.Add("value", "Wartosć");
            dataGridViewResults.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewResults.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            for (int j = 0; j < Saaty.Alternative.Count; j++)
            {
                dataGridViewResults.Rows.Add(Saaty.Alternative.Name[j], Saaty.Result.Results[j]);
            }
            dataGridViewResults.Sort(dataGridViewResults.Columns[1], ListSortDirection.Descending);
            dataGridViewResults.Rows[0].Selected = true;
        }



        #endregion

    }
}
