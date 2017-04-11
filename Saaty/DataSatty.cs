using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saaty
{
    public class DataSatty
    {
        public List<String> ListCriteria { get; set; }
        public List<String> ListAlternative { get; set; }
        public List<List<float>> MatrixCriteria { get; set; }
        public List<List<List<float>>> MatrixAlternative { get; set; }

        public DataSatty()
        {
            ListCriteria = new List<string>();
            ListAlternative = new List<string>();
        }

        public void setMatrixAlternative()
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
        }

        public void setMatrixCriteria()
        {
            MatrixCriteria = new List<List<float>>();
            for (int i = 0; i < ListCriteria.Count; i++)
            {
                MatrixCriteria.Add(new List<float>());
                for (int j = 0; j < ListCriteria.Count; j++)
                    MatrixCriteria[i].Add(1);
            }
        }

        public void Clear()
        {
            ListCriteria.Clear();
            ListAlternative.Clear();
            MatrixCriteria.Clear();
            MatrixAlternative.Clear();
        }
    }
}
