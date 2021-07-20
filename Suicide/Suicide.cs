using CommandSystem;
using Exiled.API.Features;
using System;

namespace Suicide
{
    [CommandHandler(typeof(ClientCommandHandler))]
    public class Suicide : ICommand
    {
        public string Command { get; } = "suicide";
        public string[] Aliases { get; } = {};
        public string Description { get; } = "Kill yourself";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Player p = Player.Get((CommandSender)sender);
            if(p.Role == RoleType.None || p.Role == RoleType.Spectator)
            {
                response = "You can't suicide with this role";
                return false;
            }
            
            if (Plugin.Singleton.Config.Roles.Contains(p.Role) || Plugin.Singleton.Config.Everyone)
            {
                p.Kill(DamageTypes.None);
                response = "Suiciding...";
                return true;
            }
            response = "You can't suicide with this role";
            return false;
        }

       
    }
}
