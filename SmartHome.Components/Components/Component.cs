using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Components
{
    public abstract class Component : IComponent, IThing
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }
    }
}
