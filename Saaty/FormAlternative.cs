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
                dataGridView.Rows.Add(_satty.Criteria.Name[j], _satty.Matrix.Data[j][id]);
            }

        }

        private void buttonAccept_Click(object sender, System.EventArgs e)
        {
            if (!_editMode)
            {
                List<double> criteriaList = new List<double>();
                for (int i = 0; i < _satty.Criteria.Count; i++)
                {
                    criteriaList.Add(double.Parse(dataGridView.Rows[i].Cells[1].Value.ToString()));
                }
                _satty.AddAlternative(textBoxAlternative.Text, criteriaList);
                _formMain.tabPageStep3_Enter(sender, e);
                _formMain.Save();
                Close();
            }
            else
            {
                List<double> criteriaList = new List<double>();
                for (int i = 0; i < _satty.Criteria.Count; i++)
                {
                    _satty.Matrix.Data[i][_id] = double.Parse(dataGridView.Rows[i].Cells[1].Value.ToString());
                }
                _satty.Alternative.Name[_id] = textBoxAlternative.Text;
                
                _formMain.tabPageStep3_Enter(sender, e);
                _formMain.Save();
                Close();
            }

        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
