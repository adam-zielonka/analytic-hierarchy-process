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
            public List<int> Weight { get; set; }

            public int Count => Name.Count;

            public void Clear()
            {
                Name.Clear();
                ValueType.Clear();
                Weight.Clear();
            }

            public void Add(string name, bool value)
            {
                Name.Add(name);
                ValueType.Add(value);
                Weight.Add(1);
            }

            public void RemoveAt(int id)
            {
                Name.RemoveAt(id);
                ValueType.RemoveAt(id);
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

            public void Clear()
            {
                FactorCriteria.Clear();
                FactorAlternative.Clear();
                Results.Clear();
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

        public void AddCriteria(string name, bool value)
        {
            Criteria.Add(name, value);
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
            for (int j = 0; j < Alternative.Count; j++)
            {
                Matrix.Data[Criteria.Count - 1].Add(double.MaxValue);
            }
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

        public void AddAlternative(string name, List<double> criteriaList)
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

        public void EditAlternative(int id, string name, List<double> criteriaList)
        {
            Alternative.Name[id] = name;
            for (int i = 0; i < Criteria.Count; i++)
            {
                Matrix.Data[i][id] = criteriaList[i];
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
            for (int i = 0; i < Criteria.Count; i++)
            {
                Matrix.Data[i].RemoveAt(id);
            }
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
            for (int i = 0; i < Criteria.Count; i++)
            {
                for (int j = 0; j < Alternative.Count; j++)
                {
                    for (int k = 0; k < Alternative.Count; k++)
                    {
                        Matrix.Alternative[i][j][k] = 0;
                    }
                }
            }
        }

        public void GenerateMatrixCriteria()
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

        public void GenerateMatrixAlternative()
        {
            for (int i = 0; i < Criteria.Count; i++)
            {

                List<double> data = new List<double>();
                for (int j = 0; j < Alternative.Count; j++)
                {
                    data.Add(Matrix.Data[i][j]);
                }


                double min = data[0], max = data[0];
                for (int j = 1; j < Alternative.Count; j++)
                {
                    if (data[j] < min) min = data[j];
                    if (data[j] > max) max = data[j];
                }

                List<int> weight = new List<int>();
                for (int j = 0; j < Alternative.Count; j++)
                {
                    weight.Add(1);
                }

                double point = max - min;
                if (point != 0)
                {
                    point /= 8;
                    for (int j = 0; j < Alternative.Count; j++)
                    {
                        double value = point;
                        for (int k = 1; ; k++)
                        {
                            if (data[j] < value)
                            {
                                weight[j] = k;
                                break;
                            }
                            value += point;
                        }
                    }
                }

                for (int j = 0; j < Alternative.Count; j++)
                {
                    for (int k = 0; k < Alternative.Count; k++)
                    {
                        if (k != j)
                        {
                            if (Criteria.ValueType[i])
                            {
                                if (weight[j] - weight[k] >= 0)
                                    Matrix.Alternative[i][k][j] = weight[j] - weight[k] + 1;
                                else
                                    Matrix.Alternative[i][k][j] = 1.0 / ((weight[j] - weight[k]) * (-1.0) + 1.0);
                            }
                            else
                            {
                                if (weight[j] - weight[k] >= 0)
                                    Matrix.Alternative[i][j][k] = weight[j] - weight[k] + 1;
                                else
                                    Matrix.Alternative[i][j][k] = 1.0 / ((weight[j] - weight[k]) * (-1.0) + 1.0);
                            }
                        }
                        else
                        {
                            Matrix.Alternative[i][j][k] = 1;
                        }
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
            }
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
