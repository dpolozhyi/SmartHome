using System;
using System.Collections.Generic;
using System.Linq;
using SmartHome.Components.Components;
using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Devices
{
    public class TV : MediaComponent
    {
        [Obsolete("Only needed for deserialization", true)]
        public TV():base("","", null, null, null, null)
        {

        }

        public TV(string name, string location, ISwitchable switcher, ISoundable volumer, IBrightable brighter, IChannable channeler) : base(name, location, switcher, volumer, brighter, channeler)
        {
            
        }
    }
}
