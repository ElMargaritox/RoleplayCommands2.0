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
        [XmlElement("CommandName")]
        public string CommandName;
        [XmlElement("Message")]
        public string Message;
        [XmlElement("Image")]
        public string Image;
        [XmlElement("ChatMode")]
        public string ChatMode;
        [XmlElement("IsAnonymous")]
        public bool IsAnonymous;
    }
}
