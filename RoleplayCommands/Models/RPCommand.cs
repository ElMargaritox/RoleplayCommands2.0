using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RoleplayCommands.Models
{
    public class RPCommand
    {
        public RPCommand() { }
        [XmlText]
        public string CommandName;
        [XmlAttribute("Message")]
        public string Message;
        [XmlAttribute("Image")]
        public string Image;
        [XmlAttribute("ChatMode")]
        public string ChatMode;
        [XmlAttribute("Anonymous")]
        public bool IsAnonymous;
    }
}
