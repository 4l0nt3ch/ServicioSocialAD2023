using System.Xml.Serialization;
using System.Xml;
using System.Formats.Asn1;

namespace uanl_ss_lib_xml_local_api
{
    public class XmlCrud<T>
    {
        private string filePath;
        private List<T> objects;
        private XmlDocument doc;

        public XmlCrud(string filePath)
        {
            this.filePath = filePath;         
            doc = new XmlDocument();
            LoadFromFile();
        }

        public List<T> GetAll() { 
            return objects;
        }

        public T GetSelected(int index) { 
            if (index > -1 && index < objects.Count)
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
            if (index > -1 && index < objects.Count)
            {
                objects[index] = obj;
                SaveToFile();
            }
        }

        public void DeleteObject(int index)
        {
            if (index > -1 && index < objects.Count)
            {
                objects.RemoveAt(index);
                SaveToFile();
            }
        }

        public void CreateFile() {

            if (!File.Exists(filePath))
            {
                using (File.Create(filePath)) { }
            }

            objects = new List<T>();

            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, objects);
            }
        }

        public void LoadFromFile()
        {
            if (File.Exists(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));

                using (StreamReader reader = new StreamReader(filePath))
                {
                    objects = (List<T>) serializer.Deserialize(reader);
                }
            }
        }

        private void SaveToFile() {

            if (objects != null)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    serializer.Serialize(writer, objects);
                }
            }

        }
    }
}