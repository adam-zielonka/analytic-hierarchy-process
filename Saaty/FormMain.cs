using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Saaty
{

    public partial class FormMain : Form
    {
        DataSatty dataSatty;
        public FormMain()
        {
            InitializeComponent();
            dataSatty = new DataSatty();
        }

        public FormMain(DataSatty _dataSatty,FormMain _formMainBasic)
        {
            InitializeComponent();
            dataSatty = _dataSatty;
        }

        #region Strip Menu

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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataSatty.Clear();
        }

        #endregion

        #region Language Settings

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            Controls.Clear();
            InitializeComponent();
        }

        private void polishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pl");
            Controls.Clear();
            InitializeComponent();
        }

        #endregion
        
        private void buttonCriteria_Click(object sender, EventArgs e)
        {
            FormManage formManage = new FormManage(dataSatty, buttonCriteria);
            formManage.Text = "Zarządzaj Kryteriami";
            formManage.Show();
        }


        private void buttonAlternative_Click(object sender, EventArgs e)
        {
            FormManage formManage = new FormManage(dataSatty, buttonAlternative, true);
            formManage.Text = "Zarządzaj Alternatywami";
            formManage.Show();
        }

        private void buttonWeightCriteria_Click(object sender, EventArgs e)
        {
            FormWeight formWeight = new FormWeight(dataSatty.ListCriteria, dataSatty.MatrixCriteria);
            formWeight.Show();
        }

        private void buttonMatrixWeight_Click(object sender, EventArgs e)
        {
            FormMatrix formMatrix = new FormMatrix(dataSatty.ListCriteria, dataSatty.MatrixCriteria);
            formMatrix.Show();
        }

        private void buttonWeightAlternative_Click(object sender, EventArgs e)
        {
            FormWeight formWeight = new FormWeight(dataSatty.ListCriteria, dataSatty.ListAlternative, dataSatty.MatrixAlternative);
            formWeight.Show();
        }

        private void buttonMatrixWeightAlternative_Click(object sender, EventArgs e)
        {
            FormMatrix formMatrix = new FormMatrix(dataSatty.ListCriteria, dataSatty.ListAlternative, dataSatty.MatrixAlternative);
            formMatrix.Show();
        }

    }
}
