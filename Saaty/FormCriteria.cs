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
        bool _EnterEntered = false;

        public FormCriteria(SattyClass satty, FormMain formMain)
        {
            InitializeComponent();
            _editMode = false;
            _satty = satty;
            _formMain = formMain;
            _id = satty.Criteria.Count;
            comboBoxValueCriteria.SelectedIndex = 0;
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
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            bool value = comboBoxValueCriteria.SelectedIndex == 1;
            if (textBoxNameCriteria.Text != "")
            {
                if (_editMode)
                {
                    _satty.Criteria.Name[_id] = textBoxNameCriteria.Text;
                    _satty.Criteria.ValueType[_id] = value;
                }
                else
                {
                    _satty.AddCriteria(textBoxNameCriteria.Text, value);
                }
                _formMain.tabPageStep1_Enter(sender, e);
                _formMain.dataGridViewCriteria.Rows[_id].Selected = true;
                _formMain.Save();
                _formMain.TabManage.HideTab(4, 1);
                Close();
            }
            else
            {
                MessageBox.Show(@"Nazwa kryterium jest wymagana.", @"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxNameCriteria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_EnterEntered)
                e.Handled = true;
        }

        private void textBoxNameCriteria_KeyDown(object sender, KeyEventArgs e)
        {
            _EnterEntered = false;

            if(e.KeyCode == Keys.Enter)
            {
                _EnterEntered = true;
                buttonAccept_Click(sender, e);
            }
        }
    }
}
