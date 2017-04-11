using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saaty
{
    public class DataSatty
    {
        public class Criteria
        {
            public List<string> Name { get; set; }
            public List<bool> ValueType { get; set; }
            public List<double> Precision { get; set; }
            public List<int> Weight { get; set; }
        }

        public class Alternative
        {
            public List<string> Name { get; set; }
        }

        public class Result
        {
            public List<double> FactorCriteria { get; set; }
            public List<List<double>> FactorAlternative { get; set; }
            public List<double> Results { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Matrix
        {
            public List<List<double>> Criteria { get; set; }
            public List<List<double>> Data { get; set; }
            public List<List<List<double>>> Alternative { get; set; }
        }

        public Criteria criteria { get; set; }
        public Alternative alternative { get; set; }
        public Matrix matrix { get; set; }
        public Result result { get; set; }

        public DataSatty()
        {
            criteria = new Criteria();
            criteria.Name = new List<string>();
            criteria.ValueType = new List<bool>();
            criteria.Precision = new List<double>();
            criteria.Weight = new List<int>();

            alternative = new Alternative();
            alternative.Name = new List<string>();

            matrix = new Matrix();
            matrix.Alternative = new List<List<List<double>>>();
            matrix.Criteria = new List<List<double>>();
            matrix.Data = new List<List<double>>();

            result = new Result();
            result.FactorCriteria = new List<double>();
            result.FactorAlternative = new List<List<double>>();
            result.Results = new List<double>();

            ClearCalculate();
        }

        public void Clear()
        {
            criteria.Name.Clear();
            criteria.ValueType.Clear();
            criteria.Precision.Clear();
            criteria.Weight.Clear();
            alternative.Name.Clear();
            matrix.Criteria.Clear();
            matrix.Alternative.Clear();
            matrix.Data.Clear();
            ClearCalculate();
        }

        #region Manage Criteria & Alternative

        public void AddCriteria(string _name, bool _value, double _precision)
        {
            criteria.Name.Add(_name);
            criteria.ValueType.Add(_value);
            criteria.Precision.Add(_precision);
            criteria.Weight.Add(1);
            matrix.Criteria.Add(new List<double>());
            for (int i = 0; i < criteria.Name.Count; i++)
                matrix.Criteria[criteria.Name.Count - 1].Add(1);
            for (int i = 0; i < criteria.Name.Count - 1; i++)
                matrix.Criteria[i].Add(1);
            matrix.Alternative.Add(new List<List<double>>());
            for (int j = 0; j < alternative.Name.Count; j++)
            {
                matrix.Alternative[criteria.Name.Count - 1].Add(new List<double>());
                for (int k = 0; k < alternative.Name.Count; k++)
                    matrix.Alternative[criteria.Name.Count - 1][j].Add(1);
            }
        }

        public void RemoveCriteria(int _id)
        {
            matrix.Alternative.RemoveAt(_id);
            for (int i = 0; i < criteria.Name.Count; i++)
                matrix.Criteria[i].RemoveAt(_id);
            matrix.Criteria.RemoveAt(_id);
            criteria.Name.RemoveAt(_id);
            criteria.ValueType.RemoveAt(_id);
            criteria.Precision.RemoveAt(_id);
            criteria.Weight.RemoveAt(_id);
        }

        public void AddAlternative(string _name)
        {
            alternative.Name.Add(_name);
            for (int i = 0; i < criteria.Name.Count; i++)
            {
                matrix.Alternative[i].Add(new List<double>());
                for (int k = 0; k < alternative.Name.Count; k++)
                    matrix.Alternative[i][alternative.Name.Count - 1].Add(1);
                for (int k = 0; k < alternative.Name.Count - 1; k++)
                    matrix.Alternative[i][k].Add(1);
            }
        }

        public void RemoveAlternative(int _id)
        {
            for (int i = 0; i < criteria.Name.Count; i++)
            {
                for (int k = 0; k < alternative.Name.Count; k++)
                    matrix.Alternative[i][k].RemoveAt(_id);
                matrix.Alternative[i].RemoveAt(_id);
            }
            alternative.Name.RemoveAt(_id);
        }

        #endregion

        #region Wieght Criteria

        public void UpCriteria(int _id)
        {
            criteria.Weight[_id]++;
            if (criteria.Weight[_id] > 9)
            {
                criteria.Weight[_id]--;
            }
        }

        public void DownCriteria(int _id)
        {
            criteria.Weight[_id]--;
            if (criteria.Weight[_id] < 1)
            {
                criteria.Weight[_id]++;
            }
        }

        #endregion

        #region Matrix

        public void ZeroMatrix()
        {
            for (int i = 0; i < criteria.Name.Count; i++)
            {
                for (int j = 0; j < criteria.Name.Count; j++)
                {
                    matrix.Criteria[i][j] = 0;
                }
            }
        }

        public void GenerateMatrix()
        {
            for (int i = 0; i < criteria.Name.Count; i++)
            {
                for (int j = 0; j < criteria.Name.Count; j++)
                {
                    if (j != i)
                    {
                        if (criteria.Weight[i] - criteria.Weight[j] >= 0)
                            matrix.Criteria[i][j] = criteria.Weight[i] - criteria.Weight[j] + 1;
                        else
                            matrix.Criteria[i][j] = 1.0 / ((criteria.Weight[i] - criteria.Weight[j]) * (-1.0) + 1.0);

                    }
                    else
                    {
                        matrix.Criteria[i][j] = 1;
                    }
                }
            }
        }

        #endregion

        #region Calculate

        public void Calculate()
        {
            if (criteria.Name.Count == 0 || alternative.Name.Count == 0)
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
            result.FactorCriteria.Clear();
            result.FactorAlternative.Clear();
            result.Results.Clear();
            result.Id = -1;
            result.Name = "No data to calculate";
        }

        private void SetResult()
        {
            result.Id = 0;
            for (int i = 1; i < result.Results.Count; i++)
            {
                if (result.Results[i] > result.Results[result.Id])
                    result.Id = i;
            }
            result.Name = alternative.Name[result.Id];
        }

        private void CalculateFactorCriteria()
        {
            result.FactorCriteria.Clear();
            for (int i = 0; i < criteria.Name.Count; i++)
                result.FactorCriteria.Add(1);

            double denominator = 0;

            for (int i = 0; i < criteria.Name.Count; i++)
            {
                for (int j = 0; j < criteria.Name.Count; j++)
                {
                    result.FactorCriteria[i] *= matrix.Criteria[i][j];
                }
                result.FactorCriteria[i] = Math.Pow(result.FactorCriteria[i], 1.0 / criteria.Name.Count);
                denominator += result.FactorCriteria[i];
            }

            for (int i = 0; i < criteria.Name.Count; i++)
            {
                result.FactorCriteria[i] /= denominator;
                result.FactorCriteria[i] *= criteria.Name.Count;
            }
        }

        private void CalculateFactorAlternative()
        {
            result.FactorAlternative.Clear();
            for (int k = 0; k < criteria.Name.Count; k++)
            {
                result.FactorAlternative.Add(new List<double>());
                for (int i = 0; i < alternative.Name.Count; i++)
                    result.FactorAlternative[k].Add(1);
            }

            for (int k = 0; k < criteria.Name.Count; k++)
            {
                double denominator = 0;
                for (int i = 0; i < alternative.Name.Count; i++)
                {
                    for (int j = 0; j < alternative.Name.Count; j++)
                    {
                        result.FactorAlternative[k][i] *= matrix.Alternative[k][i][j];
                    }
                    result.FactorAlternative[k][i] = Math.Pow(result.FactorAlternative[k][i], 1.0 / alternative.Name.Count);
                    denominator += result.FactorAlternative[k][i];
                }

                for (int i = 0; i < alternative.Name.Count; i++)
                {
                    result.FactorAlternative[k][i] /= denominator;
                    result.FactorAlternative[k][i] *= alternative.Name.Count;
                }
            }
        }

        private void CalculateResult()
        {
            result.Results.Clear();
            for (int i = 0; i < alternative.Name.Count; i++)
                result.Results.Add(0);

            for (int k = 0; k < alternative.Name.Count; k++)
                for (int j = 0; j < criteria.Name.Count; j++)
                {
                    result.Results[k] += result.FactorAlternative[j][k] * result.FactorCriteria[j];
                }
        }

        #endregion
    }
}
