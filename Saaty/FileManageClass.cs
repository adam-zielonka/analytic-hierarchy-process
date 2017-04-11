using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Saaty
{
    public class FileManageClass
    {
        object _projectObject;
        string _fileName;
        public FileManageClass(object projectObject)
        {
            _projectObject = projectObject;
            _fileName = "";
        }

        public void New()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = @"Analytic Hierarchy Process File|*.ahp",
                Title = @"Zapisz projekt do pliku"
            };
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                _fileName = saveFileDialog.FileName;
                XmlSerializer writer = new XmlSerializer(_projectObject.GetType());
                StreamWriter file = new StreamWriter(saveFileDialog.FileName);
                writer.Serialize(file, _projectObject);
                file.Close();
            }
        }

        public object Open()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = @"Analytic Hierarchy Process File|*.ahp",
                Title = @"Otwórz projekt z pliku"
            };
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                _fileName = openFileDialog.FileName;
                XmlSerializer serializer = new XmlSerializer(_projectObject.GetType());
                StreamReader reader = new StreamReader(openFileDialog.FileName);
                _projectObject = serializer.Deserialize(reader);
                reader.Close();
            }
            return _projectObject;
        }

        public void Save()
        {
            if (_fileName != "")
            {
                XmlSerializer writer = new XmlSerializer(_projectObject.GetType());
                StreamWriter file = new StreamWriter(_fileName);
                writer.Serialize(file, _projectObject);
                file.Close();
            }
        }

        public string GetFileName()
        {
            return _fileName;
        }


    }
}
