using System;
using SmartHome.Components.Components;
using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Devices
{
    public class Recorder : AudioComponent
    {
        [Obsolete("Only needed for deserialization", true)]
        public Recorder() : base("","",null,null)
        {

        }

        public Recorder(string name, string location, ISwitchable switcher, ISoundable volumer) : base(name, location, switcher, volumer)
        {

        }
    }
}
