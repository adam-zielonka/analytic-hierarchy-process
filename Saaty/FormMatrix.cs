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
        private List<string> _listAlternative;
        private List<List<List<float>>> _matrixAlternative;
        public FormMatrix(List<string> listCriteria, List<List<float>> matrix)
        {
            InitializeComponent();
            comboBoxCriteria.Hide();
            dataGridView1.Dock = DockStyle.Fill;
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

        public FormMatrix(List<string> listCriteria, List<string> listAlternative, List<List<List<float>>> matrixAlternative)
        {
            InitializeComponent();
            _listCriteria = listCriteria;
            _listAlternative = listAlternative;
            _matrixAlternative = matrixAlternative;

            for (int i = 0; i < _listCriteria.Count; i++)
                comboBoxCriteria.Items.Add(_listCriteria[i]);
        }

        private void comboBoxCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            for (int k = 0; k < _listCriteria.Count; k++)
                if (comboBoxCriteria.Text == _listCriteria[k])
                {
                    for (int i = 0; i < _listAlternative.Count; i++)
                        dataGridView1.Columns.Add(i.ToString(), _listAlternative[i].ToString());
                    for (int i = 0; i < _listAlternative.Count; i++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].HeaderCell.Value = _listAlternative[i].ToString();
                    }

                    for (int i = 0; i < _listAlternative.Count; i++)
                        for (int j = 0; j < _listAlternative.Count; j++)
                            dataGridView1.Rows[i].Cells[j].Value = _matrixAlternative[k][i][j];
                }
        }
    }
}
