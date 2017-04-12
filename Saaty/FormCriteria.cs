using System;
using System.Globalization;
using System.Windows.Forms;

namespace Saaty
{
    public partial class FormCriteria : Form
    {
        SaatyClass _saaty;
        FormMain _formMain;
        bool _editMode;
        int _id;
        bool _EnterEntered = false;

        public FormCriteria(SaatyClass saaty, FormMain formMain)
        {
            InitializeComponent();
            _editMode = false;
            _saaty = saaty;
            _formMain = formMain;
            _id = saaty.Criteria.Count;
            comboBoxValueCriteria.SelectedIndex = 0;
        }

        public FormCriteria(SaatyClass saaty, FormMain formMain, int id)
        {
            InitializeComponent();
            _editMode = true;
            _saaty = saaty;
            _formMain = formMain;
            _id = id;
            int value = 0;
            if (_saaty.Criteria.ValueType[id]) value = 1;
            textBoxNameCriteria.Text = _saaty.Criteria.Name[id];
            comboBoxValueCriteria.SelectedIndex = value;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            bool value = comboBoxValueCriteria.SelectedIndex == 1;
            if (textBoxNameCriteria.Text != "")
            {
                if (_editMode)
                {
                    _saaty.Criteria.Name[_id] = textBoxNameCriteria.Text;
                    _saaty.Criteria.ValueType[_id] = value;
                }
                else
                {
                    _saaty.AddCriteria(textBoxNameCriteria.Text, value);
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
