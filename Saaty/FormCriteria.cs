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
        DataSatty dataSatty;
        FormMain formMain;
        bool editMode;
        int id;

        public FormCriteria(DataSatty _dataSatty, FormMain _formMain)
        {
            InitializeComponent();
            editMode = false;
            dataSatty = _dataSatty;
            formMain = _formMain;
            id = _dataSatty.ListCriteria.Count();
            comboBoxValueCriteria.SelectedIndex = 0;
            comboBoxPrecisionCriteria.SelectedIndex = 4;
        }

        public FormCriteria(DataSatty _dataSatty, FormMain _formMain, int _id)
        {
            InitializeComponent();
            editMode = true;
            dataSatty = _dataSatty;
            formMain = _formMain;
            id = _id;
            int value = 0;
            if (dataSatty.ListCriteriaValueType[_id]) value = 1;
            textBoxNameCriteria.Text = dataSatty.ListCriteria[_id];
            comboBoxValueCriteria.SelectedIndex = value;
            comboBoxPrecisionCriteria.Text = dataSatty.ListCriteriaPrecision[_id].ToString();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            bool value = comboBoxValueCriteria.SelectedIndex == 1;
            if (editMode)
            {
                dataSatty.ListCriteria[id] = textBoxNameCriteria.Text;
                dataSatty.ListCriteriaValueType[id] = value;
                dataSatty.ListCriteriaPrecision[id] = double.Parse(comboBoxPrecisionCriteria.Text);
            }
            else
            {
                dataSatty.AddCriteria(textBoxNameCriteria.Text, value, double.Parse(comboBoxPrecisionCriteria.Text));
            }
            formMain.tabPageStep1_Enter(sender, e);
            formMain.dataGridViewCriteria.Rows[id].Selected = true;
            formMain.Save();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
