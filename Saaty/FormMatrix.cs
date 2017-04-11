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
        private List<string> _listCriteria;
        private List<List<float>> _matrix;
        public FormMatrix(List<string> listCriteria, List<List<float>> matrix)
        {
            InitializeComponent();
            _matrix = matrix;
            _listCriteria = listCriteria;
            for (int i = 0; i < _listCriteria.Count; i++)
                dataGridView1.Columns.Add(i.ToString(), _listCriteria[i].ToString());
            for (int i = 0; i < _listCriteria.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].HeaderCell.Value = _listCriteria[i].ToString();
            }
            for (int i = 0; i < _listCriteria.Count; i++)
                for (int j = 0; j < _listCriteria.Count; j++)
                    dataGridView1.Rows[i].Cells[j].Value = _matrix[i][j];


        }
    }
}
