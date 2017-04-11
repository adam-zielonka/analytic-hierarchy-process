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
            if (textBoxAddKryteria.Text != "")
            {
                listBoxKryteria.Items.Add(textBoxAddKryteria.Text);
                textBoxAddKryteria.Text = "";
            }
        }

        private void buttonAddAlternatywy_Click(object sender, EventArgs e)
        {
            if (textBoxAddAlternatywy.Text != "")
            {
                listBoxAlternatywy.Items.Add(textBoxAddAlternatywy.Text);
                textBoxAddAlternatywy.Text = "";
            }
        }

        private void buttonCreateGrid_Click(object sender, EventArgs e)
        {
            buttonDodajAlternatywy.Enabled = false;
            buttonDodajKryteria.Enabled = false;
            buttonCreateGrid.Enabled = false;
            buttonUsunAlternatywy.Enabled = false;
            buttonUsunKryteria.Enabled = false;
            for (int i = 0; i < listBoxKryteria.Items.Count; i++)
            {
                dataGridViewKA.Columns.Add(i.ToString(), listBoxKryteria.Items[i].ToString());
                comboBoxKryteria.Items.Add(listBoxKryteria.Items[i].ToString());
            }

            for (int i = 0; i < listBoxAlternatywy.Items.Count; i++)
            {
                dataGridViewKA.Rows.Add();
                dataGridViewKA.Rows[i].HeaderCell.Value = listBoxAlternatywy.Items[i].ToString();
            }

            for (int i = 0; i < listBoxKryteria.Items.Count; i++)
                dataGridViewParzystePorownania.Columns.Add(i.ToString(), listBoxKryteria.Items[i].ToString());
            for (int i = 0; i < listBoxKryteria.Items.Count; i++)
            {
                dataGridViewParzystePorownania.Rows.Add();
                dataGridViewParzystePorownania.Rows[i].HeaderCell.Value = listBoxKryteria.Items[i].ToString();
            }


        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            listBoxAlternatywy.Items.Clear();
            listBoxKryteria.Items.Clear();
            dataGridViewKA.Columns.Clear();
            dataGridViewKA.Rows.Clear();
            dataGridViewParzystePorownania.Columns.Clear();
            dataGridViewParzystePorownania.Rows.Clear();
            dataGridViewWagiKryterium.Columns.Clear();
            dataGridViewWagiKryterium.Rows.Clear();
            comboBoxKryteria.Items.Clear();
            comboBoxKryteria.Text = "";
            buttonDodajAlternatywy.Enabled = true;
            buttonDodajKryteria.Enabled = true;
            buttonCreateGrid.Enabled = true;
            buttonUsunAlternatywy.Enabled = true;
            buttonUsunKryteria.Enabled = true;
            buttonPrzykladoweDane.Enabled = true;

        }

        private void buttonUsunKryteria_Click(object sender, EventArgs e)
        {
            if (listBoxKryteria.SelectedItems.Count != 0)
                listBoxKryteria.Items.RemoveAt(listBoxKryteria.SelectedIndex);
        }

        private void buttonUsunAlternatywy_Click(object sender, EventArgs e)
        {
            if (listBoxAlternatywy.SelectedItems.Count != 0)
                listBoxAlternatywy.Items.RemoveAt(listBoxAlternatywy.SelectedIndex);
        }

        private void buttonPrzykladoweDane_Click(object sender, EventArgs e)
        {

            buttonReset_Click(sender, e);
            buttonPrzykladoweDane.Enabled = false;

            listBoxAlternatywy.Items.Add("mBank");
            listBoxAlternatywy.Items.Add("Bank Milenium");
            listBoxAlternatywy.Items.Add("Bank BPH");

            listBoxKryteria.Items.Add("Sieć placówek");
            listBoxKryteria.Items.Add("Oprocentowanie kredytu");
            listBoxKryteria.Items.Add("Opłaty");
            listBoxKryteria.Items.Add("Sieć bankomatów");
            listBoxKryteria.Items.Add("Okres nieoprocentowanego kredytu");

            buttonCreateGrid_Click(sender, e);

            dataGridViewKA.Rows[0].Cells[0].Value = "25";
            dataGridViewKA.Rows[0].Cells[1].Value = "19.90";
            dataGridViewKA.Rows[0].Cells[2].Value = "50";
            dataGridViewKA.Rows[0].Cells[3].Value = "87";
            dataGridViewKA.Rows[0].Cells[4].Value = "54";

            dataGridViewKA.Rows[1].Cells[0].Value = "50";
            dataGridViewKA.Rows[1].Cells[1].Value = "16.90";
            dataGridViewKA.Rows[1].Cells[2].Value = "38";
            dataGridViewKA.Rows[1].Cells[3].Value = "200";
            dataGridViewKA.Rows[1].Cells[4].Value = "52";

            dataGridViewKA.Rows[2].Cells[0].Value = "62";
            dataGridViewKA.Rows[2].Cells[1].Value = "21.90";
            dataGridViewKA.Rows[2].Cells[2].Value = "70";
            dataGridViewKA.Rows[2].Cells[3].Value = "150";
            dataGridViewKA.Rows[2].Cells[4].Value = "56";


        }

        private void buttonPrzeliczenie_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewParzystePorownania.ColumnCount; i++)
                dataGridViewParzystePorownania.Rows[i].Cells[i].Value = "1";
            for (int i = 0; i < listBoxKryteria.Items.Count; i++)
            {
                if (listBoxKryteria.Items[i].ToString() == comboBoxKryteria.Text)
                {
                    for (int j = 0, k = 0; j < listBoxKryteria.Items.Count; j++, k++)
                    {
                        if (j == i)
                        {
                            k--;
                        }
                        else
                        {
                            if (dataGridViewWagiKryterium.Rows[0].Cells[k].Value != null)
                            {
                                float res;
                                if (float.TryParse(dataGridViewWagiKryterium.Rows[0].Cells[k].Value.ToString(), out res) == true)
                                {
                                    dataGridViewParzystePorownania.Rows[i].Cells[j].Value = dataGridViewWagiKryterium.Rows[0].Cells[k].Value;
                                    dataGridViewParzystePorownania.Rows[j].Cells[i].Value = (float)1 / res;
                                }

                            }

                        }

                    }
                }
            }
        }

        private void dataGridViewParzystePorownania_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //buttonPrzeliczenie_Click(sender, e);
            for (int i = 0; i < dataGridViewParzystePorownania.ColumnCount; i++)
                dataGridViewParzystePorownania.Rows[i].Cells[i].Value = "1";
            for (int i = 0; i < listBoxKryteria.Items.Count; i++)
            {
                for (int j = 0; j < listBoxKryteria.Items.Count; j++)
                {
                    if (dataGridViewParzystePorownania.Rows[i].Cells[j].Value != null)
                    {
                        float res;
                        if (float.TryParse(dataGridViewParzystePorownania.Rows[i].Cells[j].Value.ToString(), out res) == true)
                        {
                            dataGridViewParzystePorownania.Rows[j].Cells[i].Value = (float)1 / res;
                        }

                    }
                }
            }
        }

        private void comboBoxKryteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewWagiKryterium.Columns.Clear();
            dataGridViewWagiKryterium.Rows.Clear();
            for (int i = 0; i < listBoxKryteria.Items.Count; i++)
            {
                if (listBoxKryteria.Items[i].ToString() != comboBoxKryteria.Text)
                {
                    dataGridViewWagiKryterium.Columns.Add(i.ToString(), listBoxKryteria.Items[i].ToString());
                }
            }
            dataGridViewWagiKryterium.Rows.Add();
            dataGridViewWagiKryterium.Rows[0].HeaderCell.Value = comboBoxKryteria.Text;
            for (int i = 0; i < listBoxKryteria.Items.Count; i++)
            {
                if (listBoxKryteria.Items[i].ToString() == comboBoxKryteria.Text)
                {
                    for (int j = 0, k = 0; j < listBoxKryteria.Items.Count; j++, k++)
                    {
                        if (j == i)
                        {
                            k--;
                        }
                        else
                        {
                            dataGridViewWagiKryterium.Rows[0].Cells[k].Value = dataGridViewParzystePorownania.Rows[i].Cells[j].Value;
                        }

                    }
                }
            }
        }

        private void buttonWagiKryterium_Click(object sender, EventArgs e)
        {
            FormWagiKrytria wagi = new FormWagiKrytria();
            wagi.Show();
        }
    }
}
