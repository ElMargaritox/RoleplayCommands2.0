using Rocket.API;
using RoleplayCommands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RoleplayCommands
{
    public class RoleplayCommandsConfiguration : IRocketPluginConfiguration
    {
        [XmlArrayItem(ElementName = "Command")]
        public List<RPCommand> RPCommands { get; set; }
        public void LoadDefaults()
        {
            RPCommands = new List<RPCommand>()
            {
                new RPCommand() {CommandName = "ooc", ChatMode = "global", Image = "https://i.imgur.com/SSWIvgh.png", Message = "(color=#ff0000)(b)[OOC](/color) (color=#FFFFFF) {0} :(/b) {1} (/color)", IsAnonymous = false},
                new RPCommand() {CommandName = "twt", ChatMode = "global", Image = "https://i.imgur.com/SSWIvgh.png", Message = "(color=#00acee)(b)[TWEET](/color) (color=#26ff00)@ {0} :(/b)(/color) (color=#FFFFFF) {1} (/color)", IsAnonymous = false},
                new RPCommand() {CommandName = "do", ChatMode = "area", Image = "https://i.imgur.com/SSWIvgh.png", Message = "(i)(color=#26ff00) * {0} (/color)* (color=#FFFFFF) [{1}] (/i)(/color)", IsAnonymous = false},
                new RPCommand() {CommandName = "me", ChatMode = "area", Image = "https://i.imgur.com/SSWIvgh.png", Message = "(color=#26ff00)(i)*{0} {1} *(/color)(/i)", IsAnonymous = false},
                new RPCommand() {CommandName = "anon", ChatMode = "global", Image = "https://i.imgur.com/AfYFjGE.png", Message = "(color=#101010)(b)[Anonymous]:(/color) (color=#ff0000) {0} (/b)(/color)", IsAnonymous = true},
            };
        }
    }
}
