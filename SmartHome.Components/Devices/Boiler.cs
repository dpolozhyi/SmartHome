﻿using System;
using SmartHome.Components.Components;
using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Devices
{
    public class Boiler : HeatComponent
    {
        [Obsolete("Only needed for deserialization", true)]
        public Boiler() : base("","",null,null)
        {

        }

        public Boiler(string name, string location, ISwitchable switcher, IHeatable heater) : base(name, location, switcher, heater)
        {

        }
    }
}
