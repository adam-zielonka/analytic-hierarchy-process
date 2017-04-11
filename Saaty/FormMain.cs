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
        public List<String> ListCriteria { get; set; }
        public List<String> ListAlternative { get; set; }
        public List<List<float>> MatrixCriteria { get; set; }
        public List<List<List<float>>> MatrixAlternative { get; set; }


        public FormMain()
        {
            InitializeComponent();
            ListCriteria = new List<string>();
            ListAlternative = new List<string>();


            ////TETS DATA
            ListAlternative.Add("mBank");
            ListAlternative.Add("Bank Milenium");
            ListAlternative.Add("Bank BPH");

            ListCriteria.Add("Sieć placówek");
            ListCriteria.Add("Oprocentowanie kredytu");
            ListCriteria.Add("Opłaty");
            ListCriteria.Add("Sieć bankomatów");
            ListCriteria.Add("Okres nieoprocentowanego kredytu");

            ////ENDTEST

        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //oknoZapis.ShowDialog();
           // if (oknoZapis.FileName != "")
          //  {
           //     XmlSerializer writer = new XmlSerializer(typeof(FormMain));
          //      StreamWriter file = new StreamWriter("save.file");
         //       writer.Serialize(file, proj);
         //       file.Close();
           // }
        }

        /*SAVE TO FILE
        w konstruktorze:
oknoZapis.Filter = "AHP|*.ahp";
            oknoZapis.Title = "Zapisz projekt do pliku";

            oknoOtworz.Filter = "AHP|*.ahp";
            oknoOtworz.Title = "Otwórz projekt z pliku";


private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oknoZapis.ShowDialog();
            if (oknoZapis.FileName != "")
            {
                XmlSerializer writer = new XmlSerializer(typeof(Projekt));
                System.IO.StreamWriter file = new StreamWriter(oknoZapis.FileName);
                writer.Serialize(file, proj);
                file.Close();
            }
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oknoOtworz.ShowDialog();
            if (oknoOtworz.FileName != "")
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Projekt));
                StreamReader reader = new StreamReader(oknoOtworz.FileName);
                proj = (Projekt)serializer.Deserialize(reader);
                reader.Close();
                pokazGrid();
            }
        }    
    */



        private void buttonCriteria_Click(object sender, EventArgs e)
        {
            buttonCriteria.Enabled = false;
            FormCriteria formCriteria = new FormCriteria(ListCriteria, buttonCriteria);
            formCriteria.Show();
        }

        private void buttonAlternative_Click(object sender, EventArgs e)
        {
            buttonAlternative.Enabled = false;
            FormCriteria formCriteria = new FormCriteria(ListAlternative, buttonAlternative, "Alternatywy");
            formCriteria.Text = "Zarządaj Alternatywami";
            formCriteria.Show();
        }

        private void buttonWeightCriteria_Click(object sender, EventArgs e)
        {
            //buttonCriteria.Enabled = false;
            MatrixCriteria = new List<List<float>>();
            for (int i = 0; i < ListCriteria.Count; i++)
            {
                MatrixCriteria.Add(new List<float>());
                for (int j = 0; j < ListCriteria.Count; j++)
                    MatrixCriteria[i].Add(1);
            }
            FormWeight formWeight = new FormWeight(ListCriteria, MatrixCriteria);
            formWeight.Show();

        }

        private void buttonMatrixWeight_Click(object sender, EventArgs e)
        {
            FormMatrix formMatrix = new FormMatrix(ListCriteria, MatrixCriteria);
            formMatrix.Show();
        }

        private void buttonWeightAlternative_Click(object sender, EventArgs e)
        {
            MatrixAlternative = new List<List<List<float>>>();
            for (int i = 0; i < ListCriteria.Count; i++)
            {
                MatrixAlternative.Add(new List<List<float>>());
                for (int j = 0; j < ListAlternative.Count; j++)
                {
                    MatrixAlternative[i].Add(new List<float>());
                    for (int k = 0; k < ListAlternative.Count; k++)
                        MatrixAlternative[i][j].Add(1);
                }
            }
            FormWeight formWeight = new FormWeight(ListCriteria, ListAlternative, MatrixAlternative);
            formWeight.Show();
        }

        private void buttonMatrixWeightAlternative_Click(object sender, EventArgs e)
        {
            FormMatrix formMatrix = new FormMatrix(ListCriteria, ListAlternative, MatrixAlternative);
            formMatrix.Show();
        }


    }
}
