using System;
using SmartHome.Components.Components;
using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Devices
{
    public class Alarm : AudioComponent
    {
        [Obsolete("Only needed for EntityFramework", true)]
        public Alarm() : base("", "", null, null)
        {

        }

        public Alarm(string name, string location, ISwitchable switcher, ISoundable volumer):base(name, location, switcher, volumer)
        {

        }
    }
}
