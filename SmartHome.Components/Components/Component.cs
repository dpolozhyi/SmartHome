using MongoDB.Bson;
using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Components
{
    public abstract class Component : IComponent, IEntity
    {
        public ObjectId Id { get; set; }

        public string Name { get; set; }

        public Component(string name)
        {
            this.Name = name;
        }
    }
}
