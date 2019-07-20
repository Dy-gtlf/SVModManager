using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SVModManager
{
    public class ModInfo
    {
        [XmlElement(ElementName = "ModActivation")]
        public bool ModActivation { get; set; }
        [XmlElement(ElementName = "ModName")]
        public string ModName { get; set; }
        [XmlElement(ElementName = "ModFolder")]
        public string ModFolder { get; set; }
    }
}
