using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Adapters
{
    public class SoundableAdapter
    {
        public int Id { get; set; }

        private readonly ISoundable volumer;

        public SoundableAdapter()
        {

        }

        public SoundableAdapter(ISoundable volumer)
        {
            this.volumer = volumer;
        }

        public ISoundable Volumer
        {
            get
            {
                return volumer;
            }
        }
    }
}
