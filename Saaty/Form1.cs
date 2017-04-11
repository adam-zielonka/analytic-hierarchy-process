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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonAddKryteria_Click(object sender, EventArgs e)
        {
            listBoxKryteria.Items.Add(textBoxAddKryteria.Text);
            textBoxAddKryteria.Text = "";
        }

        private void buttonAddAlternatywy_Click(object sender, EventArgs e)
        {
            listBoxAlternatywy.Items.Add(textBoxAddAlternatywy.Text);
            textBoxAddAlternatywy.Text = "";
        }

        private void buttonCreateGrid_Click(object sender, EventArgs e)
        {
            buttonAddAlternatywy.Enabled = false;
            buttonAddKryteria.Enabled = false;
            buttonCreateGrid.Enabled = false;
            for (int i = 0; i < listBoxKryteria.Items.Count; i++)
                dataGridViewKA.Columns.Add(i.ToString(), listBoxKryteria.Items[i].ToString());
            for (int i = 0; i < listBoxAlternatywy.Items.Count; i++)
            {
                dataGridViewKA.Rows.Add();
                dataGridViewKA.Rows[i].HeaderCell.Value = listBoxAlternatywy.Items[i].ToString();
            }
                

        }

    }
}
