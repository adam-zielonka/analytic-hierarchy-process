using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saaty
{
    public class DataSatty
    {
        public List<string> ListCriteria { get; set; }
        public List<bool> ListCriteriaValueType { get; set; }
        public List<double> ListCriteriaPrecision { get; set; }
        public List<int> ListCriteriaWeight { get; set; }
        public List<string> ListAlternative { get; set; }
        public List<List<double>> MatrixCriteria { get; set; }
        public List<List<double>> MatrixData { get; set; }
        public List<List<List<double>>> MatrixAlternative { get; set; }
        public List<double> ListFactorCriteria { get; set; }
        public List<List<double>> ListFactorAlternative { get; set; }
        public List<double> ListResult { get; set; }
        public int ResultId { get; set; }
        public string ResultName { get; set; }

        public DataSatty()
        {
            ListCriteria = new List<string>();
            ListCriteriaValueType = new List<bool>();
            ListCriteriaPrecision = new List<double>();
            ListCriteriaWeight = new List<int>();
            ListAlternative = new List<string>();
            MatrixAlternative = new List<List<List<double>>>();
            MatrixCriteria = new List<List<double>>();
            MatrixData = new List<List<double>>();
            ListFactorCriteria = new List<double>();
            ListFactorAlternative = new List<List<double>>();
            ListResult = new List<double>();
            ClearCalculate();
        }

        public void Clear()
        {
            ListCriteria.Clear();
            ListCriteriaValueType.Clear();
            ListCriteriaPrecision.Clear();
            ListCriteriaWeight.Clear();
            ListAlternative.Clear();
            MatrixCriteria.Clear();
            MatrixAlternative.Clear();
            MatrixData.Clear();
            ClearCalculate();
        }

        #region Manage Criteria & Alternative

        public void AddCriteria(string _name, bool _value, double _precision)
        {
            ListCriteria.Add(_name);
            ListCriteriaValueType.Add(_value);
            ListCriteriaPrecision.Add(_precision);
            ListCriteriaWeight.Add(1);
            MatrixCriteria.Add(new List<double>());
            for (int i = 0; i < ListCriteria.Count; i++)
                MatrixCriteria[ListCriteria.Count - 1].Add(1);
            for (int i = 0; i < ListCriteria.Count - 1; i++)
                MatrixCriteria[i].Add(1);
            MatrixAlternative.Add(new List<List<double>>());
            for (int j = 0; j < ListAlternative.Count; j++)
            {
                MatrixAlternative[ListCriteria.Count - 1].Add(new List<double>());
                for (int k = 0; k < ListAlternative.Count; k++)
                    MatrixAlternative[ListCriteria.Count - 1][j].Add(1);
            }
        }

        public void RemoveCriteria(int _id)
        {
            MatrixAlternative.RemoveAt(_id);
            for (int i = 0; i < ListCriteria.Count; i++)
                MatrixCriteria[i].RemoveAt(_id);
            MatrixCriteria.RemoveAt(_id);
            ListCriteria.RemoveAt(_id);
            ListCriteriaValueType.RemoveAt(_id);
            ListCriteriaPrecision.RemoveAt(_id);
            ListCriteriaWeight.RemoveAt(_id);
        }

        public void AddAlternative(string _name)
        {
            ListAlternative.Add(_name);
            for (int i = 0; i < ListCriteria.Count; i++)
            {
                MatrixAlternative[i].Add(new List<double>());
                for (int k = 0; k < ListAlternative.Count; k++)
                    MatrixAlternative[i][ListAlternative.Count - 1].Add(1);
                for (int k = 0; k < ListAlternative.Count - 1; k++)
                    MatrixAlternative[i][k].Add(1);
            }
        }

        public void RemoveAlternative(int _id)
        {
            for (int i = 0; i < ListCriteria.Count; i++)
            {
                for (int k = 0; k < ListAlternative.Count; k++)
                    MatrixAlternative[i][k].RemoveAt(_id);
                MatrixAlternative[i].RemoveAt(_id);
            }
            ListAlternative.RemoveAt(_id);
        }

        #endregion

        #region Wieght Criteria

        public void UpCriteria(int _id)
        {
            ListCriteriaWeight[_id]++;
            if (ListCriteriaWeight[_id] > 9)
            {
                ListCriteriaWeight[_id]--;
            }
        }

        public void DownCriteria(int _id)
        {
            ListCriteriaWeight[_id]--;
            if (ListCriteriaWeight[_id] < 1)
            {
                ListCriteriaWeight[_id]++;
            }
        }

        #endregion

        #region Matrix

        public void ZeroMatrix()
        {
            for (int i = 0; i < ListCriteria.Count; i++)
            {
                for (int j = 0; j < ListCriteria.Count; j++)
                {
                        MatrixCriteria[i][j] = 0;
                }
            }
        }

        public void GenerateMatrix()
        {
            for (int i = 0; i < ListCriteria.Count; i++)
            {
                for (int j = 0; j < ListCriteria.Count; j++)
                {
                    if (j != i)
                    {
                        if (ListCriteriaWeight[i] - ListCriteriaWeight[j] >= 0)
                            MatrixCriteria[i][j] = ListCriteriaWeight[i] - ListCriteriaWeight[j] + 1;
                        else
                            MatrixCriteria[i][j] = 1.0 / ((ListCriteriaWeight[i] - ListCriteriaWeight[j]) * (-1.0) + 1.0);

                    }
                    else
                    {
                        MatrixCriteria[i][j] = 1;
                    }
                }
            }
        }

        #endregion

        #region Calculate

        public void Calculate()
        {
            if (ListCriteria.Count == 0 || ListAlternative.Count == 0)
            {
                ClearCalculate();
            }
            else
            {
                CalculateFactorCriteria();
                CalculateFactorAlternative();
                CalculateResult();
                SetResult();
            }
        }

        private void ClearCalculate()
        {
            ListFactorCriteria.Clear();
            ListFactorAlternative.Clear();
            ListResult.Clear();
            ResultId = -1;
            ResultName = "No data to calculate";
        }

        private void SetResult()
        {
            ResultId = 0;
            for (int i = 1; i < ListResult.Count; i++)
            {
                if (ListResult[i] > ListResult[ResultId])
                    ResultId = i;
            }
            ResultName = ListAlternative[ResultId];
        }

        private void CalculateFactorCriteria()
        {
            ListFactorCriteria.Clear();
            for (int i = 0; i < ListCriteria.Count; i++)
                ListFactorCriteria.Add(1);

            double denominator = 0;

            for (int i = 0; i < ListCriteria.Count; i++)
            {
                for (int j = 0; j < ListCriteria.Count; j++)
                {
                    ListFactorCriteria[i] *= MatrixCriteria[i][j];
                }
                ListFactorCriteria[i] = Math.Pow(ListFactorCriteria[i], 1.0 / ListCriteria.Count);
                denominator += ListFactorCriteria[i];
            }

            for (int i = 0; i < ListCriteria.Count; i++)
            {
                ListFactorCriteria[i] /= denominator;
                ListFactorCriteria[i] *= ListCriteria.Count;
            }
        }

        private void CalculateFactorAlternative()
        {
            ListFactorAlternative.Clear();
            for (int k = 0; k < ListCriteria.Count; k++)
            {
                ListFactorAlternative.Add(new List<double>());
                for (int i = 0; i < ListAlternative.Count; i++)
                    ListFactorAlternative[k].Add(1);
            }

            for (int k = 0; k < ListCriteria.Count; k++)
            {
                double denominator = 0;
                for (int i = 0; i < ListAlternative.Count; i++)
                {
                    for (int j = 0; j < ListAlternative.Count; j++)
                    {
                        ListFactorAlternative[k][i] *= MatrixAlternative[k][i][j];
                    }
                    ListFactorAlternative[k][i] = Math.Pow(ListFactorAlternative[k][i], 1.0 / ListAlternative.Count);
                    denominator += ListFactorAlternative[k][i];
                }

                for (int i = 0; i < ListAlternative.Count; i++)
                {
                    ListFactorAlternative[k][i] /= denominator;
                    ListFactorAlternative[k][i] *= ListAlternative.Count;
                }
            }
        }

        private void CalculateResult()
        {
            ListResult.Clear();
            for (int i = 0; i < ListAlternative.Count; i++)
                ListResult.Add(0);

            for (int k = 0; k < ListAlternative.Count; k++)
                for (int j = 0; j < ListCriteria.Count; j++)
                {
                    ListResult[k] += ListFactorAlternative[j][k] * ListFactorCriteria[j];
                }
        }

        #endregion
    }
}
