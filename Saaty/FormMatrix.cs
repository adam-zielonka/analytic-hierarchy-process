using System.Windows.Forms;

namespace Saaty
{
    public partial class FormMatrix : Form
    {
        private SattyClass _satty;
        public FormMatrix(SattyClass satty)
        {
            InitializeComponent();
            comboBoxCriteria.Hide();
            for (int i = 0; i < satty.Criteria.Count; i++)
                dataGridView1.Columns.Add(i.ToString(), satty.Criteria.Name[i]);
            for (int i = 0; i < satty.Criteria.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].HeaderCell.Value = satty.Criteria.Name[i];
            }
            for (int i = 0; i < satty.Criteria.Count; i++)
                for (int j = 0; j < satty.Criteria.Count; j++)
                    dataGridView1.Rows[i].Cells[j].Value = satty.Matrix.Criteria[i][j];

        }

        public FormMatrix(SattyClass satty,bool alternativeMode)
        {
            InitializeComponent();
            _satty = satty;

            for (int i = 0; i < _satty.Criteria.Count; i++)
                comboBoxCriteria.Items.Add(_satty.Criteria.Name[i]);
        }

        private void comboBoxCriteria_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            for (int k = 0; k < _satty.Criteria.Count; k++)
                if (comboBoxCriteria.Text == _satty.Criteria.Name[k])
                {
                    for (int i = 0; i < _satty.Alternative.Count; i++)
                        dataGridView1.Columns.Add(i.ToString(), _satty.Alternative.Name[i].ToString());
                    for (int i = 0; i < _satty.Alternative.Count; i++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].HeaderCell.Value = _satty.Alternative.Name[i].ToString();
                    }

                    for (int i = 0; i < _satty.Alternative.Count; i++)
                        for (int j = 0; j < _satty.Alternative.Count; j++)
                            dataGridView1.Rows[i].Cells[j].Value = _satty.Matrix.Alternative[k][i][j];
                }
        }
    }
}
