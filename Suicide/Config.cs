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
        [Description("Roles that can use the command .suicide")]
        public List<RoleType> Roles = new List<RoleType> { RoleType.ChaosInsurgency, RoleType.ClassD, RoleType.FacilityGuard, RoleType.NtfCadet, RoleType.NtfCommander , RoleType.NtfLieutenant, RoleType.Scientist};
    }
}
