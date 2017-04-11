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
    public partial class FormCriteria : Form
    {
        private List<string> _listCriteria;
        private DataSatty _dataSatty;
        private Button _button;
        public FormCriteria(List<string> listCriteria,DataSatty dataSatty, Button button, string text = "Kryteria")
        {
            InitializeComponent();
            dataGridViewCriteria.Columns[0].HeaderText = text;
            buttonSaveCriteria.Text = "Zapisz " + text;
            _listCriteria = listCriteria;
            _dataSatty = dataSatty;
            _button = button;
            loadCriteria();
        }

        private void loadCriteria()
        {
            for (int i = 0; i < _listCriteria.Count; i++)
                dataGridViewCriteria.Rows.Add(_listCriteria[i]);
        }

        private void saveCriteria()
        {
            _listCriteria.Clear();
            for (int i = 0; i < dataGridViewCriteria.Rows.Count - 1; i++)
                _listCriteria.Add(dataGridViewCriteria.Rows[i].Cells[0].Value.ToString());

        }

        private void buttonSaveCriteria_Click(object sender, EventArgs e)
        {
            saveCriteria();
            _dataSatty.setMatrixAlternative();
            _dataSatty.setMatrixCriteria();
            this.Close();
        }

        private void FormCriteria_FormClosed(object sender, FormClosedEventArgs e)
        {
            _button.Enabled = true;
        }
    }
}