using System.Collections.Generic;
using System.Xml.Serialization;

namespace SVModManager
{
    [XmlRoot(ElementName = "ModList")]
    public class ModList
    {
        [XmlElement(ElementName = "ModInfo")]
        public List<ModInfo> ModInfo { get; set; } = new List<ModInfo>();
    }
}
