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
        private List<string> _listAlternative;
        private List<Label> labelList;
        private List<ComboBox> comboBoxWeightList;
        private List<List<float>> _matrix;
        private List<List<List<float>>> _matrixAlternative;
        private bool alternative;
        public FormWeight(List<string> listCriteria, List<List<float>> matrix)
        {
            InitializeComponent();
            _listCriteria = listCriteria;
            _matrix = matrix;
            alternative = false;
            labelList = new List<Label>();
            comboBoxWeightList = new List<ComboBox>();

            for (int i = 0; i < _listCriteria.Count; i++)
            {
                for (int j = i + 1; j < _listCriteria.Count; j++)
                {
                    labelList.Add(new Label());
                    labelList[labelList.Count - 1].Location = new Point(12, 44 + 15 * (labelList.Count - 1));
                    labelList[labelList.Count - 1].Text = _listCriteria[i];
                    labelList[labelList.Count - 1].RightToLeft = RightToLeft.Yes;
                    Controls.Add(labelList[labelList.Count - 1]);

                    comboBoxWeightList.Add(new ComboBox());
                    comboBoxWeightList[comboBoxWeightList.Count - 1].Location = new Point(112, 41 + 15 * (labelList.Count - 1));
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
                    comboBoxWeightList[comboBoxWeightList.Count - 1].Text = loadWeightCriteria(i,j);

                    Controls.Add(comboBoxWeightList[comboBoxWeightList.Count - 1]);

                    labelList.Add(new Label());
                    labelList[labelList.Count - 1].Location = new Point(235 + 240, 44 + 15 * (labelList.Count - 2));
                    labelList[labelList.Count - 1].Text = _listCriteria[j];
                    Controls.Add(labelList[labelList.Count - 1]);
                }
            }
        }
        public FormWeight(List<string> listCriteria, List<string> listAlternative, List<List<List<float>>> matrixAlternative)
        {
            InitializeComponent();
            _listCriteria = listCriteria;
            _listAlternative = listAlternative;
            _matrixAlternative = matrixAlternative;
            alternative = true;

            labelList = new List<Label>();
            comboBoxWeightList = new List<ComboBox>();

            for (int k = 0; k < _listCriteria.Count; k++)
            {
                labelList.Add(new Label());
                labelList[labelList.Count - 1].Location = new Point(12, 35 + 15 * (labelList.Count - 1));
                labelList[labelList.Count - 1].Text = _listCriteria[k];
                Controls.Add(labelList[labelList.Count - 1]);

                for (int i = 0; i < _listAlternative.Count; i++)
                {
                    for (int j = i + 1; j < _listAlternative.Count; j++)
                    {
                        labelList.Add(new Label());
                        labelList[labelList.Count - 1].Location = new Point(12, 44 + 15 * (labelList.Count - 1));
                        labelList[labelList.Count - 1].Text = _listAlternative[i];
                        labelList[labelList.Count - 1].RightToLeft = RightToLeft.Yes;
                        Controls.Add(labelList[labelList.Count - 1]);

                        comboBoxWeightList.Add(new ComboBox());
                        comboBoxWeightList[comboBoxWeightList.Count - 1].Location = new Point(112, 41 + 15 * (labelList.Count - 1));
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
                        comboBoxWeightList[comboBoxWeightList.Count - 1].Text = loadWeightAlternative(k, i, j);

                        Controls.Add(comboBoxWeightList[comboBoxWeightList.Count - 1]);

                        labelList.Add(new Label());
                        labelList[labelList.Count - 1].Location = new Point(235 + 240, 44 + 15 * (labelList.Count - 2));
                        labelList[labelList.Count - 1].Text = _listAlternative[j];
                        Controls.Add(labelList[labelList.Count - 1]);
                    }
                }
            }
        }
        private void saveWeightCriteria()
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
        }
        private string loadWeightCriteria(int i, int j)
        {
            if (_matrix[i][j] == 1) return "Oba elementy są równoznaczne";
            if (_matrix[i][j] == 2) return "Pierwszy element ma niewielką przewagę nad drugim";
            if (_matrix[i][j] == 3) return "Pierwszy element ma umiarkowaną przewagę nad drugim";
            if (_matrix[i][j] == 4) return "Pierwszy element ma umiarkowanie silną przewagę nad drugim";
            if (_matrix[i][j] == 5) return "Pierwszy element ma znaczną przewagę nad drugim";
            if (_matrix[i][j] == 6) return "Pierwszy element ma silną przewagę nad drugim";
            if (_matrix[i][j] == 7) return "Pierwszy element ma bardzo silną przewagę nad drugim";
            if (_matrix[i][j] == 8) return "Pierwszy element ma bardzo silną, ale nie absolutną przewagę nad drugim";
            if (_matrix[i][j] == 9) return "Pierwszy element ma absolutną przewagę nad drugim";
            if (_matrix[i][j] == (float)1 / 2) return "Drugi element ma niewielką przewagę nad pierwszym";
            if (_matrix[i][j] == (float)1 / 3) return "Drugi element ma umiarkowaną przewagę nad pierwszym";
            if (_matrix[i][j] == (float)1 / 4) return "Drugi element ma umiarkowanie silną przewagę nad pierwszym";
            if (_matrix[i][j] == (float)1 / 5) return "Drugi element ma znaczną przewagę nad pierwszym";
            if (_matrix[i][j] == (float)1 / 6) return "Drugi element ma silną przewagę nad pierwszym";
            if (_matrix[i][j] == (float)1 / 7) return "Drugi element ma bardzo silną przewagę nad pierwszym";
            if (_matrix[i][j] == (float)1 / 8) return "Drugi element ma bardzo silną, ale nie absolutną przewagę nad pierwszym";
            if (_matrix[i][j] == (float)1 / 9) return "Drugi element ma absolutną przewagę nad pierwszym";
            return "";
        }
        private void saveWeightAlternative()
        {
            int number = 0;
            for (int k = 0; k < _listCriteria.Count; k++)
            {
                for (int i = 0; i < _listAlternative.Count; i++)
                {
                    for (int j = i + 1; j < _listAlternative.Count; j++)
                    {
                        switch (comboBoxWeightList[number].Text)
                        {
                            case "Oba elementy są równoznaczne":
                                _matrixAlternative[k][i][j] = 1;
                                _matrixAlternative[k][j][i] = 1;
                                break;
                            case "Pierwszy element ma niewielką przewagę nad drugim":
                                _matrixAlternative[k][i][j] = 2;
                                _matrixAlternative[k][j][i] = (float)1 / 2;
                                break;
                            case "Pierwszy element ma umiarkowaną przewagę nad drugim":
                                _matrixAlternative[k][i][j] = 3;
                                _matrixAlternative[k][j][i] = (float)1 / 3;
                                break;
                            case "Pierwszy element ma umiarkowanie silną przewagę nad drugim":
                                _matrixAlternative[k][i][j] = 4;
                                _matrixAlternative[k][j][i] = (float)1 / 4;
                                break;
                            case "Pierwszy element ma znaczną przewagę nad drugim":
                                _matrixAlternative[k][i][j] = 5;
                                _matrixAlternative[k][j][i] = (float)1 / 5;
                                break;
                            case "Pierwszy element ma silną przewagę nad drugim":
                                _matrixAlternative[k][i][j] = 6;
                                _matrixAlternative[k][j][i] = (float)1 / 6;
                                break;
                            case "Pierwszy element ma bardzo silną przewagę nad drugim":
                                _matrixAlternative[k][i][j] = 7;
                                _matrixAlternative[k][j][i] = (float)1 / 7;
                                break;
                            case "Pierwszy element ma bardzo silną, ale nie absolutną przewagę nad drugim":
                                _matrixAlternative[k][i][j] = 8;
                                _matrixAlternative[k][j][i] = (float)1 / 8;
                                break;
                            case "Pierwszy element ma absolutną przewagę nad drugim":
                                _matrixAlternative[k][i][j] = 9;
                                _matrixAlternative[k][j][i] = (float)1 / 9;
                                break;
                            case "Drugi element ma niewielką przewagę nad pierwszym":
                                _matrixAlternative[k][i][j] = (float)1 / 2;
                                _matrixAlternative[k][j][i] = 2;
                                break;
                            case "Drugi element ma umiarkowaną przewagę nad pierwszym":
                                _matrixAlternative[k][i][j] = (float)1 / 3;
                                _matrixAlternative[k][j][i] = 3;
                                break;
                            case "Drugi element ma umiarkowanie silną przewagę nad pierwszym":
                                _matrixAlternative[k][i][j] = (float)1 / 4;
                                _matrixAlternative[k][j][i] = 4;
                                break;
                            case "Drugi element ma znaczną przewagę nad pierwszym":
                                _matrixAlternative[k][i][j] = (float)1 / 5;
                                _matrixAlternative[k][j][i] = 5;
                                break;
                            case "Drugi element ma silną przewagę nad pierwszym":
                                _matrixAlternative[k][i][j] = (float)1 / 6;
                                _matrixAlternative[k][j][i] = 6;
                                break;
                            case "Drugi element ma bardzo silną przewagę nad pierwszym":
                                _matrixAlternative[k][i][j] = (float)1 / 7;
                                _matrixAlternative[k][j][i] = 7;
                                break;
                            case "Drugi element ma bardzo silną, ale nie absolutną przewagę nad pierwszym":
                                _matrixAlternative[k][i][j] = (float)1 / 8;
                                _matrixAlternative[k][j][i] = 8;
                                break;
                            case "Drugi element ma absolutną przewagę nad pierwszym":
                                _matrixAlternative[k][i][j] = (float)1 / 9;
                                _matrixAlternative[k][j][i] = 9;
                                break;
                            default:
                                _matrixAlternative[k][i][j] = 0;
                                _matrixAlternative[k][j][i] = 0;
                                break;
                        }
                        number++;
                    }
                }
            }
        }
        private string loadWeightAlternative(int k,int i, int j)
        {
            if (_matrixAlternative[k][i][j] == 1) return "Oba elementy są równoznaczne";
            if (_matrixAlternative[k][i][j] == 2) return "Pierwszy element ma niewielką przewagę nad drugim";
            if (_matrixAlternative[k][i][j] == 3) return "Pierwszy element ma umiarkowaną przewagę nad drugim";
            if (_matrixAlternative[k][i][j] == 4) return "Pierwszy element ma umiarkowanie silną przewagę nad drugim";
            if (_matrixAlternative[k][i][j] == 5) return "Pierwszy element ma znaczną przewagę nad drugim";
            if (_matrixAlternative[k][i][j] == 6) return "Pierwszy element ma silną przewagę nad drugim";
            if (_matrixAlternative[k][i][j] == 7) return "Pierwszy element ma bardzo silną przewagę nad drugim";
            if (_matrixAlternative[k][i][j] == 8) return "Pierwszy element ma bardzo silną, ale nie absolutną przewagę nad drugim";
            if (_matrixAlternative[k][i][j] == 9) return "Pierwszy element ma absolutną przewagę nad drugim";
            if (_matrixAlternative[k][i][j] == (float)1 / 2) return "Drugi element ma niewielką przewagę nad pierwszym";
            if (_matrixAlternative[k][i][j] == (float)1 / 3) return "Drugi element ma umiarkowaną przewagę nad pierwszym";
            if (_matrixAlternative[k][i][j] == (float)1 / 4) return "Drugi element ma umiarkowanie silną przewagę nad pierwszym";
            if (_matrixAlternative[k][i][j] == (float)1 / 5) return "Drugi element ma znaczną przewagę nad pierwszym";
            if (_matrixAlternative[k][i][j] == (float)1 / 6) return "Drugi element ma silną przewagę nad pierwszym";
            if (_matrixAlternative[k][i][j] == (float)1 / 7) return "Drugi element ma bardzo silną przewagę nad pierwszym";
            if (_matrixAlternative[k][i][j] == (float)1 / 8) return "Drugi element ma bardzo silną, ale nie absolutną przewagę nad pierwszym";
            if (_matrixAlternative[k][i][j] == (float)1 / 9) return "Drugi element ma absolutną przewagę nad pierwszym";
            return "";
        }
        private void buttonSaveWeight_Click(object sender, EventArgs e)
        {
            if (alternative)
                saveWeightAlternative();
            else
                saveWeightCriteria();
            Close();
        }
    }
}
