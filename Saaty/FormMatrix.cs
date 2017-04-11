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
    public partial class FormMatrix : Form
    {
        public FormMatrix(DataSatty _dataSatty)
        {
            InitializeComponent();
            for (int i = 0; i < _dataSatty.ListCriteria.Count; i++)
                dataGridView1.Columns.Add(i.ToString(), _dataSatty.ListCriteria[i].ToString());
            for (int i = 0; i < _dataSatty.ListCriteria.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].HeaderCell.Value = _dataSatty.ListCriteria[i].ToString();
            }
            for (int i = 0; i < _dataSatty.ListCriteria.Count; i++)
                for (int j = 0; j < _dataSatty.ListCriteria.Count; j++)
                    dataGridView1.Rows[i].Cells[j].Value = _dataSatty.MatrixCriteria[i][j];

        }
    }
}
