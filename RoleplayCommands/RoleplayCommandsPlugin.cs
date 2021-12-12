using Rocket.Core;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleplayCommands
{
    public class RoleplayCommandsPlugin : RocketPlugin<RoleplayCommandsConfiguration>
    {
        public static RoleplayCommandsPlugin Instance { get; set; }
        protected override void Load()
        {
            Instance = this;
            foreach (var command in Configuration.Instance.RPCommands)
            {
                Command cmd = new Command(command.CommandName, command.Message, command.Image, command.ChatMode, command.IsAnonymous);
                R.Commands.Register(cmd);
            }
            Logger.Log("Plugin Creado Por Margarita#8172 - EnvyHosting");

        }

        protected override void Unload()
        {
            foreach (var command in Configuration.Instance.RPCommands)
            {
                R.Commands.DeregisterFromAssembly(this.Assembly);
            }
            Instance = null;
        }
    }
}
