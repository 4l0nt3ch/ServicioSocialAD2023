using System.Security.AccessControl;
using System.Xml.Serialization;
using System.IO;

namespace uanl_ss_lib_xml_local_api
{
    public class XmlCrud<T>
    {
        private string filePath;
        private List<T> objects;

        public XmlCrud(string filePath)
        {
            this.filePath = filePath;
            objects = new List<T>();
            LoadFromFile();
        }

        public List<T> GetAll() { 
            return objects;
        }

        public T GetSelected(int index) { 
            if (index < 0 || index >= objects.Count)
            {
                return objects[index];
            }
            else {
                return default(T);
            }
        }

        public void CreateObject(T obj) { 
            objects.Add(obj);
            SaveToFile();
        }

        public void UpdateObject(T obj, int index) { 
            if (index >= 0 && index < objects.Count)
            {
                objects[index] = obj;
                SaveToFile();
            }
        }

        public void DeleteObject(int index)
        {
            if (index >= 0 && index < objects.Count)
            {
                objects.RemoveAt(index);
                SaveToFile();
            }
        }

        public void LoadFromFile()
        {
            if (File.Exists(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                using (StreamReader reader = new StreamReader(filePath))
                {
                    objects = (List<T>) serializer.Deserialize(reader);
                }
            }
        }

        private void SaveToFile() { 
            XmlSerializer serializer = new XmlSerializer (typeof(T));

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, objects);
            }
        }
    }
}