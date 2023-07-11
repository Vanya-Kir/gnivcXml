using System.Xml.Serialization;

namespace gnivcXml.zvregbenz
{
    /// <summary>
    /// Файл обмена 
    /// </summary>
    [XmlRoot("Файл")]
    public class File
    {
        [XmlIgnore]
        public int id;

        [XmlAttribute("ИдФайл")]
        public string Idfile;

        [XmlAttribute("ВерсПрог")]
        public string versprog;

        [XmlAttribute("ВерсФорм")]
        public string versform;

        [XmlElement("Документ")]
        public Document document;

        public string title { get ; set; }
        public long size { get; set; }
        public DateOnly getdate { get; set; }
        public DateOnly enddate { get; set; }

        /// <summary>
        /// сохранение данных о xml файле
        /// </summary>
        /// <param name="path"></param>
        public void SaveMetaData(string path)
        {
            this.title = Path.GetFileName(path);
            this.size = new FileInfo(path).Length;
            this.getdate = DateOnly.FromDateTime(new FileInfo(path).CreationTime);
            this.enddate = DateOnly.FromDateTime(DateTime.Now);
        }

        public override string ToString()
        {
            return $"id: {id}, " +
                $"Организация: {document.svnp.npyl.shortname}, " +
                $"Подписант: {document.signer.fio.surname} {document.signer.fio.name} {document.signer.fio.otchestvo}, " +
                $"Дата: {document.datedoc}";
        }
    }
}
