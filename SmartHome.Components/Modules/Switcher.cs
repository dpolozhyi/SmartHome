﻿using SmartHome.Components.Interfaces;
using System;

namespace SmartHome.Components.Modules
{
    public class Switcher : ISwitchable, IEntity
    {
        public Guid Id { get; set; }

        protected bool Condition { get; set; }

        public Switcher() : this(false)
        {

        }

        public Switcher(bool condition)
        {
            this.Condition = condition;
        }

        public void SwitchOn()
        {
            this.Condition = true;
        }

        public void SwitchOff()
        {
            this.Condition = false;
        }

        public bool IsOn()
        {
            return this.Condition;
        }
    }
}
