using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Components
{
    public class Switcher : ISwitchable
    {
        protected bool condition;

        public void SwitchOn()
        {
            this.condition = true;
        }

        public void SwitchOff()
        {
            this.condition = false;
        }

        public bool IsOn()
        {
            return this.condition;
        }
    }
}
