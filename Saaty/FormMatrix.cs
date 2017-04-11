using System.Windows.Forms;

namespace Saaty
{
    public partial class FormMatrix : Form
    {
        public FormMatrix(SattyClass satty)
        {
            InitializeComponent();
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
    }
}
