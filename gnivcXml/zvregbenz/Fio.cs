using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace gnivcXml.zvregbenz
{
    /// <summary>
    /// Фамилия, имя, отчество 
    /// </summary>
    public class Fio
    {
        [XmlAttribute("Фамилия")]
        public string surname;

        [XmlAttribute("Имя")]
        public string name;

        [XmlAttribute("Отчество")]
        public string? otchestvo;
    }
}
