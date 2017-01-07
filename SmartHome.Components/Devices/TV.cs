﻿using System;
using System.Collections.Generic;
using System.Linq;
using SmartHome.Components.Components;
using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Devices
{
    public class TV : MediaComponent
    {
        [Obsolete("Only needed for EntityFramework", true)]
        public TV():base("","", null, null, null, null)
        {

        }

        public TV(string name, string location, ISwitchable switcher, ISoundable volumer, IBrightable brighter, IChannable channeler) : base(name, location, switcher, volumer, brighter, channeler)
        {
            
        }

        public void TurnOn()
        {
            Switcher.SwitchOn();
        }

        public void TurnOff()
        {
            Switcher.SwitchOff();
        }

        public bool IsOn()
        {
            return Switcher.IsOn();
        }

        public bool SetChannel(string channel)
        {
            return Channeler.SetChannel(channel);
        }

        public string GetCurrentChannel()
        {
            return Channeler.GetCurrentChannel();
        }

        public IList<string> GetChannelList()
        {
            return Channeler.GetChannelsList().ToList();
        }

        public void NextChannel()
        {
            Channeler.NextChannel();
        }
    }
}
