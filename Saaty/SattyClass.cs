using System;
using System.Collections.Generic;

namespace Saaty
{
    public class SattyClass
    {
        #region Inside Class

        public class CriteriaClass
        {
            public List<string> Name { get; set; }
            public List<bool> ValueType { get; set; }
            public List<double> Precision { get; set; }
            public List<int> Weight { get; set; }

            public int Count => Name.Count;

            public void Clear()
            {
                Name.Clear();
                ValueType.Clear();
                Precision.Clear();
                Weight.Clear();
            }

            public void Add(string name, bool value, double precision)
            {
                Name.Add(name);
                ValueType.Add(value);
                Precision.Add(precision);
                Weight.Add(1);
            }

            public void RemoveAt(int id)
            {
                Name.RemoveAt(id);
                ValueType.RemoveAt(id);
                Precision.RemoveAt(id);
                Weight.RemoveAt(id);
            }
        }

        public class AlternativeClass
        {
            public List<string> Name { get; set; }

            public int Count => Name.Count;

            public void Clear()
            {
                Name.Clear();
            }

            public void Add(string name)
            {
                Name.Add(name);
            }

            public void RemoveAt(int id)
            {
                Name.RemoveAt(id);
            }
        }

        public class ResultClass
        {
            public List<double> FactorCriteria { get; set; }
            public List<List<double>> FactorAlternative { get; set; }
            public List<double> Results { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }

            public void Clear()
            {
                FactorCriteria.Clear();
                FactorAlternative.Clear();
                Results.Clear();
                Id = -1;
                Name = "No data to calculate";
            }
        }

        public class MatrixClass
        {
            public List<List<double>> Criteria { get; set; }
            public List<List<double>> Data { get; set; }
            public List<List<List<double>>> Alternative { get; set; }

            public void Clear()
            {
                Criteria.Clear();
                Data.Clear();
                Alternative.Clear();
            }
        }

        #endregion

        public CriteriaClass Criteria { get; set; }
        public AlternativeClass Alternative { get; set; }
        public MatrixClass Matrix { get; set; }
        public ResultClass Result { get; set; }

        public SattyClass()
        {
            Criteria = new CriteriaClass
            {
                Name = new List<string>(),
                ValueType = new List<bool>(),
                Precision = new List<double>(),
                Weight = new List<int>()
            };

            Alternative = new AlternativeClass
            {
                Name = new List<string>()
            };

            Matrix = new MatrixClass
            {
                Alternative = new List<List<List<double>>>(),
                Criteria = new List<List<double>>(),
                Data = new List<List<double>>()
            };

            Result = new ResultClass
            {
                FactorCriteria = new List<double>(),
                FactorAlternative = new List<List<double>>(),
                Results = new List<double>(),
                Id = -1,
                Name = "No data to calculate",
            };

        }

        public void Clear()
        {
            Criteria.Clear();
            Alternative.Clear();
            Matrix.Clear();
            Result.Clear();
        }

        #region Manage Criteria & Alternative

        public void AddCriteria(string name, bool value, double precision)
        {
            Criteria.Add(name, value, precision);
            Matrix.Criteria.Add(new List<double>());
            for (int i = 0; i < Criteria.Count; i++)
                Matrix.Criteria[Criteria.Count - 1].Add(1);
            for (int i = 0; i < Criteria.Count - 1; i++)
                Matrix.Criteria[i].Add(1);
            Matrix.Alternative.Add(new List<List<double>>());
            for (int j = 0; j < Alternative.Count; j++)
            {
                Matrix.Alternative[Criteria.Count - 1].Add(new List<double>());
                for (int k = 0; k < Alternative.Count; k++)
                    Matrix.Alternative[Criteria.Count - 1][j].Add(1);
            }
            Matrix.Data.Add(new List<double>());
        }

        public void RemoveCriteria(int id)
        {
            Matrix.Alternative.RemoveAt(id);
            for (int i = 0; i < Criteria.Count; i++)
                Matrix.Criteria[i].RemoveAt(id);
            Matrix.Criteria.RemoveAt(id);
            Criteria.RemoveAt(id);
            Matrix.Data.RemoveAt(id);
        }

        public void AddAlternative(string name,List<double> criteriaList)
        {
            Alternative.Add(name);
            for (int i = 0; i < Criteria.Count; i++)
            {
                Matrix.Alternative[i].Add(new List<double>());
                for (int k = 0; k < Alternative.Count; k++)
                    Matrix.Alternative[i][Alternative.Count - 1].Add(1);
                for (int k = 0; k < Alternative.Count - 1; k++)
                    Matrix.Alternative[i][k].Add(1);
            }
            for (int i = 0; i < Criteria.Count; i++)
            {
                Matrix.Data[i].Add(criteriaList[i]);
            }
        }

        public void RemoveAlternative(int id)
        {
            for (int i = 0; i < Criteria.Count; i++)
            {
                for (int k = 0; k < Alternative.Count; k++)
                    Matrix.Alternative[i][k].RemoveAt(id);
                Matrix.Alternative[i].RemoveAt(id);
            }
            Alternative.RemoveAt(id);
        }

        #endregion

        #region Wieght Criteria

        public void UpCriteria(int id)
        {
            Criteria.Weight[id]++;
            if (Criteria.Weight[id] > 9)
            {
                Criteria.Weight[id]--;
            }
        }

        public void DownCriteria(int id)
        {
            Criteria.Weight[id]--;
            if (Criteria.Weight[id] < 1)
            {
                Criteria.Weight[id]++;
            }
        }

        #endregion

        #region Matrix

        public void ZeroMatrix()
        {
            for (int i = 0; i < Criteria.Count; i++)
            {
                for (int j = 0; j < Criteria.Count; j++)
                {
                    Matrix.Criteria[i][j] = 0;
                }
            }
        }

        public void GenerateMatrix()
        {
            for (int i = 0; i < Criteria.Count; i++)
            {
                for (int j = 0; j < Criteria.Count; j++)
                {
                    if (j != i)
                    {
                        if (Criteria.Weight[i] - Criteria.Weight[j] >= 0)
                            Matrix.Criteria[i][j] = Criteria.Weight[i] - Criteria.Weight[j] + 1;
                        else
                            Matrix.Criteria[i][j] = 1.0 / ((Criteria.Weight[i] - Criteria.Weight[j]) * (-1.0) + 1.0);

                    }
                    else
                    {
                        Matrix.Criteria[i][j] = 1;
                    }
                }
            }
        }

        #endregion

        #region Calculate

        public void Calculate()
        {
            if (Criteria.Count == 0 || Alternative.Count == 0)
            {
                Result.Clear();
            }
            else
            {
                CalculateFactorCriteria();
                CalculateFactorAlternative();
                CalculateResult();
                SetResult();
            }
        }

        private void SetResult()
        {
            Result.Id = 0;
            for (int i = 1; i < Result.Results.Count; i++)
            {
                if (Result.Results[i] > Result.Results[Result.Id])
                    Result.Id = i;
            }
            Result.Name = Alternative.Name[Result.Id];
        }

        private void CalculateFactorCriteria()
        {
            Result.FactorCriteria.Clear();
            for (int i = 0; i < Criteria.Count; i++)
                Result.FactorCriteria.Add(1);

            double denominator = 0;

            for (int i = 0; i < Criteria.Count; i++)
            {
                for (int j = 0; j < Criteria.Count; j++)
                {
                    Result.FactorCriteria[i] *= Matrix.Criteria[i][j];
                }
                Result.FactorCriteria[i] = Math.Pow(Result.FactorCriteria[i], 1.0 / Criteria.Count);
                denominator += Result.FactorCriteria[i];
            }

            for (int i = 0; i < Criteria.Count; i++)
            {
                Result.FactorCriteria[i] /= denominator;
                Result.FactorCriteria[i] *= Criteria.Count;
            }
        }

        private void CalculateFactorAlternative()
        {
            Result.FactorAlternative.Clear();
            for (int k = 0; k < Criteria.Count; k++)
            {
                Result.FactorAlternative.Add(new List<double>());
                for (int i = 0; i < Alternative.Count; i++)
                    Result.FactorAlternative[k].Add(1);
            }

            for (int k = 0; k < Criteria.Count; k++)
            {
                double denominator = 0;
                for (int i = 0; i < Alternative.Count; i++)
                {
                    for (int j = 0; j < Alternative.Count; j++)
                    {
                        Result.FactorAlternative[k][i] *= Matrix.Alternative[k][i][j];
                    }
                    Result.FactorAlternative[k][i] = Math.Pow(Result.FactorAlternative[k][i], 1.0 / Alternative.Count);
                    denominator += Result.FactorAlternative[k][i];
                }

                for (int i = 0; i < Alternative.Count; i++)
                {
                    Result.FactorAlternative[k][i] /= denominator;
                    Result.FactorAlternative[k][i] *= Alternative.Count;
                }
            }
        }

        private void CalculateResult()
        {
            Result.Results.Clear();
            for (int i = 0; i < Alternative.Count; i++)
                Result.Results.Add(0);

            for (int k = 0; k < Alternative.Count; k++)
                for (int j = 0; j < Criteria.Count; j++)
                {
                    Result.Results[k] += Result.FactorAlternative[j][k] * Result.FactorCriteria[j];
                }
        }

        #endregion
    }
}
