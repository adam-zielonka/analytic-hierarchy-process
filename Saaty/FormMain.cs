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
        public FormMain()
        {
            InitializeComponent();
            dataSatty = new DataSatty();
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

        private void buttonCriteria_Click(object sender, EventArgs e)
        {
            buttonCriteria.Enabled = false;
            FormCriteria formCriteria = new FormCriteria(dataSatty.ListCriteria, buttonCriteria);
            formCriteria.Show();
        }

        private void buttonCriteria_EnabledChanged(object sender, EventArgs e)
        {
            if (buttonCriteria.Enabled == true)
            {
                dataSatty.setMatrixCriteria();
            }
        }

        private void buttonAlternative_Click(object sender, EventArgs e)
        {
            buttonAlternative.Enabled = false;
            FormCriteria formCriteria = new FormCriteria(dataSatty.ListAlternative, buttonAlternative, "Alternatywy");
            formCriteria.Text = "Zarządaj Alternatywami";
            formCriteria.Show();
        }

        private void buttonAlternative_EnabledChanged(object sender, EventArgs e)
        {
            if (buttonAlternative.Enabled == true)
            {
                dataSatty.setMatrixAlternative();
            }
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
