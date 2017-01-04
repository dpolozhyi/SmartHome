using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Components
{
    public abstract class AudioComponent : Component
    {
        ISwitchable switcher;

        ISoundable volumer;

        public AudioComponent(ISwitchable switcher, ISoundable volumer)
        {

        }

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

        public void VolumeUp()
        {
            if (this.volume < 100)
            {
                this.volume++;
            }
        }

        public void VolumeDown()
        {
            if (this.volume > 0)
            {
                this.volume--;
            }
        }

        public int GetCurrentVolume()
        {
            return volume;
        }
    }
}
