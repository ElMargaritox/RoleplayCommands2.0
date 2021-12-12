using Rocket.API;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace RoleplayCommands
{
    public class Command : IRocketCommand
    {
        private string name;
        private string message;
        private string icon;
        private string modo;
        private bool isanonymous;

        public Command(string name, string message, string icon, string modo, bool isanonymous)
        {
            this.name = name;
            this.message = message;
            this.icon = icon;
            this.modo = modo;
            this.isanonymous = isanonymous;
        }

        public AllowedCaller AllowedCaller
        {
            get { return AllowedCaller.Both; }
        }

        public string Name
        {
            get { return name; }
        }

        public string Help
        {
            get { return "EnvyHosting"; }
        }

        public string Syntax
        {
            get { return ""; }
        }

        public List<string> Aliases
        {
            get { return new List<string>(); }
        }

        public List<string> Permissions
        {
            get { return new List<string>(); }
        }

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer player = (UnturnedPlayer)caller;

            string mensaje = string.Join(" ", command);

            if(this.modo.ToLower() == "global" & !this.isanonymous)
            {
                ChatManager.serverSendMessage(string.Format(this.message, player.CharacterName, mensaje), Color.white, null, null, EChatMode.GLOBAL, this.icon, true);
                return;
            }
            else if(this.modo.ToLower() == "area" & !this.isanonymous)
            {
                ChatManager.serverSendMessage(string.Format(this.message, mensaje), Color.white, null, null, EChatMode.LOCAL, this.icon, true);
                return;
            }
            else if(this.modo.ToLower() == "global" & this.isanonymous)
            {
                ChatManager.serverSendMessage(string.Format(this.message, mensaje), Color.white, null, null, EChatMode.GLOBAL, this.icon, true);
                return;
            }
            else
            {
                ChatManager.serverSendMessage("Error en la configuracion de RoleplayCommands. Revísa", Color.white, null, player.SteamPlayer(), EChatMode.WELCOME, this.icon, true);
                return;
            }


        }
    }
}
