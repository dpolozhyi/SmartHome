using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.Components.Interfaces
{
    public interface ISoundable
    {
        void VolumeUp();

        void VolumeDown();

        int GetCurrentVolume();
    }
}
