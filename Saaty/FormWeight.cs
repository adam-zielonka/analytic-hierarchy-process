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
    public partial class FormWeight : Form
    {
        private List<string> _listCriteria;
        private List<Label> labelCriteriaList;
        private List<ComboBox> comboBoxWeightList;
        private List<List<float>> _matrix;
        public FormWeight(List<string> listCriteria, List<List<float>> matrix)
        {
            InitializeComponent();
            _listCriteria = listCriteria;
            _matrix = matrix;

            labelCriteriaList = new List<Label>();
            comboBoxWeightList = new List<ComboBox>();

            for (int i = 0; i < _listCriteria.Count; i++)
            {
                for (int j = i + 1; j < _listCriteria.Count; j++)
                {
                    labelCriteriaList.Add(new Label());
                    labelCriteriaList[labelCriteriaList.Count - 1].Location = new Point(12, 44 + 15 * (labelCriteriaList.Count - 1));
                    labelCriteriaList[labelCriteriaList.Count - 1].Text = _listCriteria[i];
                    labelCriteriaList[labelCriteriaList.Count - 1].RightToLeft = RightToLeft.Yes;
                    Controls.Add(labelCriteriaList[labelCriteriaList.Count - 1]);

                    comboBoxWeightList.Add(new ComboBox());
                    comboBoxWeightList[comboBoxWeightList.Count - 1].Location = new Point(112, 41 + 15 * (labelCriteriaList.Count - 1));
                    comboBoxWeightList[comboBoxWeightList.Count - 1].Size = new Size(360, 10);
                    comboBoxWeightList[comboBoxWeightList.Count - 1].Items.Add("Oba elementy są równoznaczne");
                    comboBoxWeightList[comboBoxWeightList.Count - 1].Items.Add("Pierwszy element ma niewielką przewagę nad drugim");
                    comboBoxWeightList[comboBoxWeightList.Count - 1].Items.Add("Pierwszy element ma umiarkowaną przewagę nad drugim");
                    comboBoxWeightList[comboBoxWeightList.Count - 1].Items.Add("Pierwszy element ma umiarkowanie silną przewagę nad drugim");
                    comboBoxWeightList[comboBoxWeightList.Count - 1].Items.Add("Pierwszy element ma znaczną przewagę nad drugim");
                    comboBoxWeightList[comboBoxWeightList.Count - 1].Items.Add("Pierwszy element ma silną przewagę nad drugim");
                    comboBoxWeightList[comboBoxWeightList.Count - 1].Items.Add("Pierwszy element ma bardzo silną przewagę nad drugim");
                    comboBoxWeightList[comboBoxWeightList.Count - 1].Items.Add("Pierwszy element ma bardzo silną, ale nie absolutną przewagę nad drugim");
                    comboBoxWeightList[comboBoxWeightList.Count - 1].Items.Add("Pierwszy element ma absolutną przewagę nad drugim");
                    comboBoxWeightList[comboBoxWeightList.Count - 1].Items.Add("Drugi element ma niewielką przewagę nad pierwszym");
                    comboBoxWeightList[comboBoxWeightList.Count - 1].Items.Add("Drugi element ma umiarkowaną przewagę nad pierwszym");
                    comboBoxWeightList[comboBoxWeightList.Count - 1].Items.Add("Drugi element ma umiarkowanie silną przewagę nad pierwszym");
                    comboBoxWeightList[comboBoxWeightList.Count - 1].Items.Add("Drugi element ma znaczną przewagę nad pierwszym");
                    comboBoxWeightList[comboBoxWeightList.Count - 1].Items.Add("Drugi element ma silną przewagę nad pierwszym");
                    comboBoxWeightList[comboBoxWeightList.Count - 1].Items.Add("Drugi element ma bardzo silną przewagę nad pierwszym");
                    comboBoxWeightList[comboBoxWeightList.Count - 1].Items.Add("Drugi element ma bardzo silną, ale nie absolutną przewagę nad pierwszym");
                    comboBoxWeightList[comboBoxWeightList.Count - 1].Items.Add("Drugi element ma absolutną przewagę nad pierwszym");

                    Controls.Add(comboBoxWeightList[comboBoxWeightList.Count - 1]);

                    labelCriteriaList.Add(new Label());
                    labelCriteriaList[labelCriteriaList.Count - 1].Location = new Point(235 + 240, 44 + 15 * (labelCriteriaList.Count - 2));
                    labelCriteriaList[labelCriteriaList.Count - 1].Text = _listCriteria[j];
                    Controls.Add(labelCriteriaList[labelCriteriaList.Count - 1]);
                }
            }
        }

        private void buttonSaveWeight_Click(object sender, EventArgs e)
        {
            int number = 0;
            for (int i = 0; i < _listCriteria.Count; i++)
            {
                for (int j = i + 1; j < _listCriteria.Count; j++)
                {
                    switch (comboBoxWeightList[number].Text)
                    {
                        case "Oba elementy są równoznaczne":
                            _matrix[i][j] = 1;
                            _matrix[j][i] = 1;
                            break;
                        case "Pierwszy element ma niewielką przewagę nad drugim":
                            _matrix[i][j] = 2;
                            _matrix[j][i] = (float)1 / 2;
                            break;
                        case "Pierwszy element ma umiarkowaną przewagę nad drugim":
                            _matrix[i][j] = 3;
                            _matrix[j][i] = (float)1 / 3;
                            break;
                        case "Pierwszy element ma umiarkowanie silną przewagę nad drugim":
                            _matrix[i][j] = 4;
                            _matrix[j][i] = (float)1 / 4;
                            break;
                        case "Pierwszy element ma znaczną przewagę nad drugim":
                            _matrix[i][j] = 5;
                            _matrix[j][i] = (float)1 / 5;
                            break;
                        case "Pierwszy element ma silną przewagę nad drugim":
                            _matrix[i][j] = 6;
                            _matrix[j][i] = (float)1 / 6;
                            break;
                        case "Pierwszy element ma bardzo silną przewagę nad drugim":
                            _matrix[i][j] = 7;
                            _matrix[j][i] = (float)1 / 7;
                            break;
                        case "Pierwszy element ma bardzo silną, ale nie absolutną przewagę nad drugim":
                            _matrix[i][j] = 8;
                            _matrix[j][i] = (float)1 / 8;
                            break;
                        case "Pierwszy element ma absolutną przewagę nad drugim":
                            _matrix[i][j] = 9;
                            _matrix[j][i] = (float)1 / 9;
                            break;
                        case "Drugi element ma niewielką przewagę nad pierwszym":
                            _matrix[i][j] = (float)1 / 2;
                            _matrix[j][i] = 2;
                            break;
                        case "Drugi element ma umiarkowaną przewagę nad pierwszym":
                            _matrix[i][j] = (float)1 / 3;
                            _matrix[j][i] = 3;
                            break;
                        case "Drugi element ma umiarkowanie silną przewagę nad pierwszym":
                            _matrix[i][j] = (float)1 / 4;
                            _matrix[j][i] = 4;
                            break;
                        case "Drugi element ma znaczną przewagę nad pierwszym":
                            _matrix[i][j] = (float)1 / 5;
                            _matrix[j][i] = 5;
                            break;
                        case "Drugi element ma silną przewagę nad pierwszym":
                            _matrix[i][j] = (float)1 / 6;
                            _matrix[j][i] = 6;
                            break;
                        case "Drugi element ma bardzo silną przewagę nad pierwszym":
                            _matrix[i][j] = (float)1 / 7;
                            _matrix[j][i] = 7;
                            break;
                        case "Drugi element ma bardzo silną, ale nie absolutną przewagę nad pierwszym":
                            _matrix[i][j] = (float)1 / 8;
                            _matrix[j][i] = 8;
                            break;
                        case "Drugi element ma absolutną przewagę nad pierwszym":
                            _matrix[i][j] = (float)1 / 9;
                            _matrix[j][i] = 9;
                            break;
                        default:
                            _matrix[i][j] = 0;
                            _matrix[j][i] = 0;
                            break;
                    }
                    number++;
                }
            }
            Close();
        }
    }
}
