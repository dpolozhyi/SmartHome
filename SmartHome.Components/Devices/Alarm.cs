using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartHome.Components.Components;
using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Devices
{
    public class Alarm : Component
    {
        ISwitchable switcher;

        ISoundable volumer;

        public Alarm(ISwitchable switcher, ISoundable volumer)
        {
            this.switcher = switcher;
            this.volumer = volumer;
        }
    }
}
