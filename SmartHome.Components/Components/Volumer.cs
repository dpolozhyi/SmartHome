using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Components
{
    public class Volumer : ISoundable
    {
        protected int volume;

        public void VolumeUp()
        {
            if(this.volume<100)
            {
                this.volume++;
            }
        }

        public void VolumeDown()
        {
            if(this.volume>0)
            {
                this.volume--;
            }
        }

        public int GetCurrentVolume()
        {
            return this.volume;
        }
    }
}
