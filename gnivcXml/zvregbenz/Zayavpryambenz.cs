using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace gnivcXml.zvregbenz
{
    /// <summary>
    /// Заявление о выдаче свидетельства о регистрации лица, совершающего операции с прямогонным бензином
    /// </summary>
    public class Zayavpryambenz
    {
        [XmlAttribute("ВидДеят")]
        public int activity;

        [XmlElement("СведПроизв", IsNullable = true)]
        public Sved svedProizv;

        [XmlElement("СведПер", IsNullable = true)]
        public Sved svedPer;
    }
}
