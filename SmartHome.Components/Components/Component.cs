using SmartHome.Components.Interfaces;
using System;

namespace SmartHome.Components.Components
{
    public abstract class Component : IComponent, IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Component(string name)
        {
            this.Name = name;
        }
    }
}
