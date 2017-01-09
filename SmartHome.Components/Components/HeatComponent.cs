using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Components
{
    public abstract class HeatComponent : Component, IThing 
    {
        public ISwitchable Switcher { get; private set; }

        public IHeatable Heater { get; private set; }

        public string Location { get; private set; }

        public HeatComponent(string name, string location, ISwitchable switcher, IHeatable heater):base(name)
        {
            this.Switcher = switcher;
            this.Heater = heater;
            this.Location = location;
        }
    }
}
