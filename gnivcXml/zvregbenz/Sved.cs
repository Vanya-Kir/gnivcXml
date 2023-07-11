using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace gnivcXml.zvregbenz
{
    /// <summary>
    /// Сведения о наличии производственных мощностей
    /// </summary>
    public class Sved
    {
        [XmlIgnore]
        public DateOnly posost { get; set; }

        [XmlAttribute("ПоСост")]
        public string _posost
        {
            get { return posost.ToString(); }
            set
            {
                posost = DateOnly.Parse(value);
            }
        }

        public List<SwedPower> swedPower;

        [XmlAnyElement("СведПроизвДата")]
        [XmlAnyElement("СведПерДата")]
        public XmlElement[] _swedPower
        {
            get
            {
                return null;
            }
            set
            {
                foreach (XmlElement xmlElement in value)
                {
                    SwedPower element = new();
                    element.adrfact = xmlElement.Attributes.GetNamedItem("АдрФакт").Value;
                    element.kppob = xmlElement.Attributes.GetNamedItem("КППОб").Value;
                    element.adrmosh = xmlElement.Attributes.GetNamedItem("АдрМощ").Value;
                    element.kppmosh = xmlElement.Attributes.GetNamedItem("КППМощ").Value;
                    element.docprav = xmlElement.Attributes.GetNamedItem("ДокПрав").Value;
                    swedPower.Add(element);
                }
            }
        }
    }
}
