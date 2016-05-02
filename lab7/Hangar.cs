using System.Collections.Generic;
using System.Xml.Serialization;

namespace lab7
{
    [XmlRoot("Hangar")]
    public class Hangar
    {
        [XmlArray("Tanks")]
        public List<Tank> Tanks { get; set; } = new List<Tank>();
    }
}
