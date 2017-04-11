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
        public FormMain()
        {
            InitializeComponent();
            dataSatty = new DataSatty();
            tabManage = new TabManage(tabControlMain, buttonNext, buttonBack);
        }

        #region Menu Strip

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataSatty.Clear();
            tabManage.SetIndex(0);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Analytic Hierarchy Process File|*.ahp";
            openFileDialog.Title = "Otwórz projekt z pliku";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                XmlSerializer serializer = new XmlSerializer(typeof(DataSatty));
                StreamReader reader = new StreamReader(openFileDialog.FileName);
                dataSatty = (DataSatty)serializer.Deserialize(reader);
                reader.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Analytic Hierarchy Process File|*.ahp";
            saveFileDialog.Title = "Zapisz projekt do pliku";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                XmlSerializer writer = new XmlSerializer(typeof(DataSatty));
                StreamWriter file = new StreamWriter(saveFileDialog.FileName);
                writer.Serialize(file, dataSatty);
                file.Close();
            }
        }

        #endregion
    }
}
