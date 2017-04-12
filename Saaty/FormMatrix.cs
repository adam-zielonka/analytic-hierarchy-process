using System.Windows.Forms;

namespace Saaty
{
    public partial class FormMatrix : Form
    {
        private SaatyClass _saaty;
        public FormMatrix(SaatyClass saaty)
        {
            InitializeComponent();
            comboBoxCriteria.Hide();
            for (int i = 0; i < saaty.Criteria.Count; i++)
                dataGridView1.Columns.Add(i.ToString(), saaty.Criteria.Name[i]);
            for (int i = 0; i < saaty.Criteria.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].HeaderCell.Value = saaty.Criteria.Name[i];
            }
            for (int i = 0; i < saaty.Criteria.Count; i++)
                for (int j = 0; j < saaty.Criteria.Count; j++)
                    dataGridView1.Rows[i].Cells[j].Value = saaty.Matrix.Criteria[i][j];

        }

        public FormMatrix(SaatyClass saaty,bool alternativeMode)
        {
            InitializeComponent();
            _saaty = saaty;

            for (int i = 0; i < _saaty.Criteria.Count; i++)
                comboBoxCriteria.Items.Add(_saaty.Criteria.Name[i]);
        }

        private void comboBoxCriteria_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            for (int k = 0; k < _saaty.Criteria.Count; k++)
                if (comboBoxCriteria.Text == _saaty.Criteria.Name[k])
                {
                    for (int i = 0; i < _saaty.Alternative.Count; i++)
                        dataGridView1.Columns.Add(i.ToString(), _saaty.Alternative.Name[i].ToString());
                    for (int i = 0; i < _saaty.Alternative.Count; i++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].HeaderCell.Value = _saaty.Alternative.Name[i].ToString();
                    }

                    for (int i = 0; i < _saaty.Alternative.Count; i++)
                        for (int j = 0; j < _saaty.Alternative.Count; j++)
                            dataGridView1.Rows[i].Cells[j].Value = _saaty.Matrix.Alternative[k][i][j];
                }
        }

        public FormMatrix(SaatyClass saaty,int nop)
        {
            InitializeComponent();
            comboBoxCriteria.Hide();
            for (int i = 0; i < saaty.Criteria.Count; i++)
                dataGridView1.Columns.Add(i.ToString(), saaty.Criteria.Name[i]);
            for (int i = 0; i < saaty.Alternative.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].HeaderCell.Value = saaty.Alternative.Name[i];
            }
            for (int i = 0; i < saaty.Criteria.Count; i++)
                for (int j = 0; j < saaty.Alternative.Count; j++)
                    dataGridView1.Rows[j].Cells[i].Value = (saaty.Matrix.Data[i][j] != double.MaxValue) ? saaty.Matrix.Data[i][j].ToString() : "";
        }

    }
}
