using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Components
{
    public abstract class HeatComponent : Component, IThing 
    {
        protected ISwitchable Switcher { get; set; }

        protected IHeatable Heater { get; set; }

        public string Location { get; set; }

        public HeatComponent(string name, string location, ISwitchable switcher, IHeatable heater):base(name)
        {
            this.Switcher = switcher;
            this.Heater = heater;
            this.Location = location;
        }
    }
}
