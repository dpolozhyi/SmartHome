using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Components
{
    public abstract class Component : IComponent
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Component(string name)
        {
            this.Name = name;
        }
    }
}
