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

        public DataSatty()
        {
            ListCriteria = new List<string>();
            ListAlternative = new List<string>();
            MatrixAlternative = new List<List<List<float>>>();
            MatrixCriteria = new List<List<float>>();
        }

        public void setMatrixAlternative()
        {
            MatrixAlternative.Clear();
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
            MatrixCriteria.Clear();
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
