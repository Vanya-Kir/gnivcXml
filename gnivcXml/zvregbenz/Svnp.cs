using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace gnivcXml.zvregbenz
{
    /// <summary>
    /// Сведения о заявителе (СвНП)
    /// </summary>
    public class Svnp
    {
        [XmlAttribute("МестоНахож")]
        public string place;

        [XmlAttribute("АдрОсущ")]
        public string adr;

        [XmlElement("НПЮЛ", IsNullable = true)]
        public Npyl npyl;

        [XmlElement("НПФЛ", IsNullable = true)]
        public Npfl npfl;
    }
}
