using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace gnivcXml.zvregbenz
{
    public class Npyl
    {
        [XmlIgnore]
        public int id;

        [XmlIgnore]
        public int document;

        [XmlAttribute("НаимОрг")]
        public string fullname;

        [XmlAttribute("НаимОргСокр")]
        public string? shortname;

        [XmlAttribute("ИННЮЛ")]
        public string innyl;

        [XmlAttribute("КПП")]
        public string kpp;
    }
}
