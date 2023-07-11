using System.Xml.Serialization;

namespace gnivcXml
{
    internal class XmlSerialize
    {
        public T ConvertXmlToObject<T>(string path)
        {
            T obj;
            using (var reader = new StreamReader(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                obj = (T)(serializer.Deserialize(reader));
            }
            return obj;
        }
    }
}
