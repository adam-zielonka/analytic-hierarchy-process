using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Saaty
{
    public partial class FormMain : Form
    {
        DataSatty dataSatty;
        TabManage tabManage;
        OpenAndSave openAndSave;
        public FormMain()
        {
            InitializeComponent();
            dataSatty = new DataSatty();
            tabManage = new TabManage(tabControlMain, buttonNext, buttonBack);
            openAndSave = new OpenAndSave(dataSatty);
        }

        #region Menu Strip

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataSatty.Clear();
            tabManage.SetIndex(0);
            dataSatty = (DataSatty)openAndSave.New();
            richTextBoxFileName.Text = openAndSave.GetFileName();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataSatty = (DataSatty)openAndSave.Open();
            richTextBoxFileName.Text = openAndSave.GetFileName();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAndSave.Save();
        }

        #endregion

        #region Start Tab
        private void buttonNewProject_Click(object sender, EventArgs e)
        {
            dataSatty = (DataSatty)openAndSave.New();
            richTextBoxFileName.Text = openAndSave.GetFileName();
        }

        private void buttonOpenProject_Click(object sender, EventArgs e)
        {
            dataSatty = (DataSatty)openAndSave.Open();
            richTextBoxFileName.Text = openAndSave.GetFileName();
        }

        #endregion

        private void buttonResults_Click(object sender, EventArgs e)
        {
            dataSatty.Calculate();
            MessageBox.Show(dataSatty.ResultName, "Wynik", MessageBoxButtons.OK);
        }
    }
}
