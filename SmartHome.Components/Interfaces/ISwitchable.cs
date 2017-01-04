﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.Components.Interfaces
{
    public interface ISwitchable
    {
        void SwitchOn();

        void SwitchOff();

        bool IsOn();
    }
}