using MongoDB.Bson;
using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Modules
{
    public class Switcher : ISwitchable, IEntity
    {
        public ObjectId Id { get; set; }

        protected bool Condition { get; set; }

        public void SwitchOn()
        {
            this.Condition = true;
        }

        public void SwitchOff()
        {
            this.Condition = false;
        }

        public bool IsOn()
        {
            return this.Condition;
        }
    }
}
