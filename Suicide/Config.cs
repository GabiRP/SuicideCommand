using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suicide
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        [Description("If this is set to true, everyone can use the command. So the config below doesn't work")]
        public bool Everyone { get; set; } = true;
        [Description("Roles that can use the command .suicide")]
        public List<RoleType> Roles { get; set; } = new List<RoleType> { RoleType.ChaosInsurgency, RoleType.ClassD, RoleType.FacilityGuard, RoleType.NtfCadet, RoleType.NtfCommander, RoleType.NtfLieutenant, RoleType.Scientist };
    }
}
