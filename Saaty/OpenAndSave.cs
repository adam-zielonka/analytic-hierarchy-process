using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Saaty
{
    class OpenAndSave
    {
        object projectObject;
        string fileName;
        public OpenAndSave(object _projectObject)
        {
            projectObject = _projectObject;
            fileName = "";
        }

        public object New()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Analytic Hierarchy Process File|*.ahp";
            saveFileDialog.Title = "Zapisz projekt do pliku";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                fileName = saveFileDialog.FileName;
                XmlSerializer writer = new XmlSerializer(projectObject.GetType());
                StreamWriter file = new StreamWriter(saveFileDialog.FileName);
                writer.Serialize(file, projectObject);
                file.Close();
            }
            return projectObject;
        }

        public object Open()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Analytic Hierarchy Process File|*.ahp";
            openFileDialog.Title = "Otwórz projekt z pliku";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                fileName = openFileDialog.FileName;
                XmlSerializer serializer = new XmlSerializer(projectObject.GetType());
                StreamReader reader = new StreamReader(openFileDialog.FileName);
                projectObject = serializer.Deserialize(reader);
                reader.Close();
            }
            return projectObject;
        }

        public void Save()
        {
            if (fileName != "")
            {
                XmlSerializer writer = new XmlSerializer(projectObject.GetType());
                StreamWriter file = new StreamWriter(fileName);
                writer.Serialize(file, projectObject);
                file.Close();
            }
        }

        public string GetFileName()
        {
            return fileName;
        }


    }
}
