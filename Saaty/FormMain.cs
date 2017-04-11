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
            openAndSave.New();
            richTextBoxFileName.Text = fileMessage(openAndSave.GetFileName(), false);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataSatty = (DataSatty)openAndSave.Open();
            richTextBoxFileName.Text = fileMessage(openAndSave.GetFileName(), true);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAndSave.Save();
        }

        #endregion

        #region Start Tab

        private string fileMessage(string _fileName,bool open)
        {
            string fileMessageText = "";
            string openOrNew;
            if (open) openOrNew = "załadowany"; else openOrNew = "utworzony";
            if (_fileName != "")
            {
                fileMessageText += "Projekt został "+openOrNew+".";
                fileMessageText += "\n\nTwoje postępy będą autoamtycznie zapisywane w pliku: ";
                fileMessageText += openAndSave.GetFileName();
                fileMessageText += "\n\nMożesz spokojnie przejść dalej.";
            }
            else
            {
                fileMessageText += "Projekt nie został " + openOrNew + ".";
            }
            return fileMessageText;
        }

        private void buttonNewProject_Click(object sender, EventArgs e)
        {
            dataSatty.Clear();
            openAndSave.New();
            richTextBoxFileName.Text = fileMessage(openAndSave.GetFileName(),false);
        }

        private void buttonOpenProject_Click(object sender, EventArgs e)
        {
            dataSatty = (DataSatty)openAndSave.Open();
            richTextBoxFileName.Text = fileMessage(openAndSave.GetFileName(),true);
        }

        #endregion

        #region Results Tab

        private void buttonResults_Click(object sender, EventArgs e)
        {
            dataSatty.Calculate();
            MessageBox.Show(dataSatty.ResultName, "Wynik", MessageBoxButtons.OK);
        }

        #endregion
    }
}
