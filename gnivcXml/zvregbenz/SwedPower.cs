using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace gnivcXml.zvregbenz
{
    /// <summary>
    /// Сведения о производственных мощностях 
    /// </summary>
    public class SwedPower
    {
        [XmlIgnore]
        public int id;

        [XmlIgnore]
        public int document;

        [XmlAttribute("АдрФакт")]
        public string adrfact;

        [XmlAttribute("КППОб")]
        public string kppob;

        [XmlAttribute("АдрМощ")]
        public string adrmosh;

        [XmlAttribute("КППМощ")]
        public string kppmosh;

        [XmlAttribute("ДокПрав")]
        public string docprav;
    }
}
