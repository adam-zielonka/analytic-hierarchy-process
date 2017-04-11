using System;
using System.Globalization;
using System.Windows.Forms;

namespace Saaty
{
    public partial class FormCriteria : Form
    {
        SattyClass _satty;
        FormMain _formMain;
        bool _editMode;
        int _id;

        public FormCriteria(SattyClass satty, FormMain formMain)
        {
            InitializeComponent();
            _editMode = false;
            _satty = satty;
            _formMain = formMain;
            _id = satty.Criteria.Count;
            comboBoxValueCriteria.SelectedIndex = 0;
            comboBoxPrecisionCriteria.SelectedIndex = 4;
        }

        public FormCriteria(SattyClass satty, FormMain formMain, int id)
        {
            InitializeComponent();
            _editMode = true;
            _satty = satty;
            _formMain = formMain;
            _id = id;
            int value = 0;
            if (_satty.Criteria.ValueType[id]) value = 1;
            textBoxNameCriteria.Text = _satty.Criteria.Name[id];
            comboBoxValueCriteria.SelectedIndex = value;
            comboBoxPrecisionCriteria.Text = _satty.Criteria.Precision[id].ToString(CultureInfo.InvariantCulture);
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            bool value = comboBoxValueCriteria.SelectedIndex == 1;
            if (_editMode)
            {
                _satty.Criteria.Name[_id] = textBoxNameCriteria.Text;
                _satty.Criteria.ValueType[_id] = value;
                _satty.Criteria.Precision[_id] = double.Parse(comboBoxPrecisionCriteria.Text);
            }
            else
            {
                _satty.AddCriteria(textBoxNameCriteria.Text, value, double.Parse(comboBoxPrecisionCriteria.Text));
            }
            _formMain.tabPageStep1_Enter(sender, e);
            _formMain.dataGridViewCriteria.Rows[_id].Selected = true;
            _formMain.Save();
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
