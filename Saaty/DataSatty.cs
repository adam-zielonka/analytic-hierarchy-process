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

        public void Clear()
        {
            ListCriteria.Clear();
            ListAlternative.Clear();
            MatrixCriteria.Clear();
            MatrixAlternative.Clear();
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

    }
}
