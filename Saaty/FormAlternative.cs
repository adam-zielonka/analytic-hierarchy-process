using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Saaty
{
    public partial class FormAlternative : Form
    {
        private FormMain _formMain;
        private SaatyClass _saaty;
        private bool _editMode;
        private int _id;

        public FormAlternative(SaatyClass saaty, FormMain formMain)
        {
            InitializeComponent();
            _saaty = saaty;
            _formMain = formMain;
            _editMode = false;
            _id = _saaty.Alternative.Count;

            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("criteria", "Kryteria");
            dataGridView.Columns[0].ReadOnly = true;
            dataGridView.Columns.Add("alternativeData", "Dane");

            for (int j = 0; j < _saaty.Criteria.Count; j++)
            {
                dataGridView.Rows.Add(_saaty.Criteria.Name[j]);
            }

        }

        public FormAlternative(SaatyClass saaty, FormMain formMain, int id)
        {
            InitializeComponent();
            _saaty = saaty;
            _formMain = formMain;
            _editMode = true;
            _id = id;

            textBoxAlternative.Text = _saaty.Alternative.Name[id];

            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("criteria", "Kryteria");
            dataGridView.Columns[0].ReadOnly = true;
            dataGridView.Columns.Add("alternativeData", "Dane");

            for (int j = 0; j < _saaty.Criteria.Count; j++)
            {
                if (_saaty.Matrix.Data[j][id] != double.MaxValue)
                {
                    dataGridView.Rows.Add(_saaty.Criteria.Name[j], _saaty.Matrix.Data[j][id]);
                }
                else
                {
                    dataGridView.Rows.Add(_saaty.Criteria.Name[j]);
                }
            }

        }

        private void buttonAccept_Click(object sender, System.EventArgs e)
        {
            bool error = false;
            List<double> criteriaList = new List<double>();

            if (textBoxAlternative.Text == "")
                error = true;

            for (int i = 0; i < _saaty.Criteria.Count; i++)
            {
                double value;
                string s = dataGridView.Rows[i].Cells[1].Value?.ToString();
                if (double.TryParse(s, out value))
                {
                    criteriaList.Add(value);
                }
                else
                    error = true;
            }
            if (!error)
            {
                if (!_editMode)
                    _saaty.AddAlternative(textBoxAlternative.Text, criteriaList);
                else
                {
                    _saaty.EditAlternative(_id, textBoxAlternative.Text, criteriaList);
                }
                _formMain.tabPageStep3_Enter(sender, e);
                _formMain.dataGridViewAlternative.Rows[_id].Selected = true;
                _formMain.Save();
                Close();
            }
            else
            {
                MessageBox.Show(@"Nie wszystkie dane są wprowadzone dobrze.", @"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
