using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Adapters
{
    public class SwitchableAdapter
    {
        public int Id { get; set; }

        private readonly ISwitchable switcher;


        public SwitchableAdapter()
        {

        }

        public SwitchableAdapter(ISwitchable switcher)
        {
            this.switcher = switcher;
        }

        public ISwitchable Switcher
        {
            get
            {
                return switcher;
            }
        }
    }
}
