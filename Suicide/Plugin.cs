using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suicide
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "Suicide Command";
        public override string Author => "GabiRP";
        public override Version Version => new Version(1,0,0);
        public static Plugin Singleton;
        public override void OnEnabled()
        {
            base.OnEnabled();
            Singleton = this;
        }
    }
}
