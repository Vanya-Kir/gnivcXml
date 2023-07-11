using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace gnivcXml.zvregbenz
{
    public class Npfl
    {
        [XmlIgnore]
        public int id;

        [XmlIgnore]
        public int document;

        [XmlAttribute("ИННФЛ")]
        public string innfl;

        [XmlElement("ФИО")]
        public Fio fio;
    }
}
