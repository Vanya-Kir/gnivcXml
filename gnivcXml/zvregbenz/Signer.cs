using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace gnivcXml.zvregbenz
{
    public class Signer
    {
        [XmlAttribute("ПрПодп")]
        public int prpodp;

        [XmlAttribute("Тлф")]
        public string phone;

        [XmlElement("ФИО")]
        public Fio fio;

        [XmlElement("СвПред")]
        public Svpred svpred;
    }

    /// <summary>
    /// Наименование документа, подтверждающего полномочия представителя
    /// </summary>
    public class Svpred
    {
        [XmlAttribute("НаимДок")]
        public string document;
    }
}
