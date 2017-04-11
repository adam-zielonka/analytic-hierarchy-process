using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Saaty
{
    public partial class FormAlternative : Form
    {
        private FormMain _formMain;
        private SattyClass _satty;
        private bool _editMode;
        private int _id;

        public FormAlternative(SattyClass satty, FormMain formMain)
        {
            InitializeComponent();
            _satty = satty;
            _formMain = formMain;
            _editMode = false;
            _id = _satty.Alternative.Count;

            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("criteria", "Kryteria");
            dataGridView.Columns[0].ReadOnly = true;
            dataGridView.Columns.Add("alternativeData", "Dane");

            for (int j = 0; j < _satty.Criteria.Count; j++)
            {
                dataGridView.Rows.Add(_satty.Criteria.Name[j]);
            }

        }

        public FormAlternative(SattyClass satty, FormMain formMain, int id)
        {
            InitializeComponent();
            _satty = satty;
            _formMain = formMain;
            _editMode = true;
            _id = id;

            textBoxAlternative.Text = _satty.Alternative.Name[id];

            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("criteria", "Kryteria");
            dataGridView.Columns[0].ReadOnly = true;
            dataGridView.Columns.Add("alternativeData", "Dane");

            for (int j = 0; j < _satty.Criteria.Count; j++)
            {
                if (_satty.Matrix.Data[j][id] != double.MaxValue)
                {
                    dataGridView.Rows.Add(_satty.Criteria.Name[j], _satty.Matrix.Data[j][id]);
                }
                else
                {
                    dataGridView.Rows.Add(_satty.Criteria.Name[j]);
                }
            }

        }

        private void buttonAccept_Click(object sender, System.EventArgs e)
        {
            bool error = false;
            List<double> criteriaList = new List<double>();

            if (textBoxAlternative.Text == "")
                error = true;

            for (int i = 0; i < _satty.Criteria.Count; i++)
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
                    _satty.AddAlternative(textBoxAlternative.Text, criteriaList);
                else
                {
                    _satty.EditAlternative(_id, textBoxAlternative.Text, criteriaList);
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
