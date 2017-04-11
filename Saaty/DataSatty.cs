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
        public List<string> ListAlternative { get; set; }
        public List<List<float>> MatrixCriteria { get; set; }
        public List<List<List<float>>> MatrixAlternative { get; set; }
        public List<float> ListFactorCriteria { get; set; }
        public List<List<float>> ListFactorAlternative { get; set; }
        public List<float> ListResult { get; set; }
        public int ResultID { get; set; }
        public string ResultName { get; set; }

        public DataSatty()
        {
            ListCriteria = new List<string>();
            ListAlternative = new List<string>();
            MatrixAlternative = new List<List<List<float>>>();
            MatrixCriteria = new List<List<float>>();
            ListFactorCriteria = new List<float>();
            ListFactorAlternative = new List<List<float>>();
            ListResult = new List<float>();
            ClearCalculate();
        }

        public void Clear()
        {
            ListCriteria.Clear();
            ListAlternative.Clear();
            MatrixCriteria.Clear();
            MatrixAlternative.Clear();
            ClearCalculate();
        }

        #region Manage Criteria & Alternative

        public void AddCriteria(string _name)
        {
            ListCriteria.Add(_name);
            MatrixCriteria.Add(new List<float>());
            for (int i = 0; i < ListCriteria.Count; i++)
                MatrixCriteria[ListCriteria.Count - 1].Add(1);
            for (int i = 0; i < ListCriteria.Count - 1; i++)
                MatrixCriteria[i].Add(1);
            MatrixAlternative.Add(new List<List<float>>());
            for (int j = 0; j < ListAlternative.Count; j++)
            {
                MatrixAlternative[ListCriteria.Count - 1].Add(new List<float>());
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
        }

        public void AddAlternative(string _name)
        {
            ListAlternative.Add(_name);
            for (int i = 0; i < ListCriteria.Count; i++)
            {
                MatrixAlternative[i].Add(new List<float>());
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
            ResultID = -1;
            ResultName = "No data to calculate";
        }

        private void SetResult()
        {
            float max = ListResult.Max();
            for (ResultID = 0; ResultID < ListResult.Count; ResultID++)
            {
                if (ListResult[ResultID] == max)
                    break;
            }
            ResultName = ListAlternative[ResultID];
        }

        private void CalculateFactorCriteria()
        {
            ListFactorCriteria.Clear();
            for (int i = 0; i < ListCriteria.Count; i++)
                ListFactorCriteria.Add(1);

            float denominator = 0;

            for (int i = 0; i < ListCriteria.Count; i++)
            {
                for (int j = 0; j < ListCriteria.Count; j++)
                {
                    ListFactorCriteria[i] *= MatrixCriteria[i][j];
                }
                ListFactorCriteria[i] = (float)Math.Pow(ListFactorCriteria[i], 1.0 / ListCriteria.Count);
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
                ListFactorAlternative.Add(new List<float>());
                for (int i = 0; i < ListAlternative.Count; i++)
                    ListFactorAlternative[k].Add(1);
            }

            for (int k = 0; k < ListCriteria.Count; k++)
            {
                float denominator = 0;
                for (int i = 0; i < ListAlternative.Count; i++)
                {
                    for (int j = 0; j < ListAlternative.Count; j++)
                    {
                        ListFactorAlternative[k][i] *= MatrixAlternative[k][i][j];
                    }
                    ListFactorAlternative[k][i] = (float)Math.Pow(ListFactorAlternative[k][i], 1.0 / ListAlternative.Count);
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
