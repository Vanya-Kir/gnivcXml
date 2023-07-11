using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace gnivcXml.zvregbenz
{
    /// <summary>
    /// Состав и структура документа 
    /// </summary>
    public class Document
    {
        [XmlAttribute("КНД")]
        public string knd;

        [XmlIgnore]
        public DateOnly datedoc { get; set; }

        [XmlAttribute("ДатаДок")]
        public string _datedoc
        {
            get { return datedoc.ToString(); }
            set
            {
                datedoc = DateOnly.Parse(value);
            }
        }

        [XmlAttribute("КодНО")]
        public string kodno;

        [XmlElement("СвНП")]
        public Svnp svnp;

        [XmlElement("Подписант")]
        public Signer signer;

        [XmlElement("ЗаявПрямБен")]
        public Zayavpryambenz zayavpryambenz;
    }
}
