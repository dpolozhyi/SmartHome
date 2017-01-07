using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Components
{
    public abstract class HeatComponent : Component, IThing 
    {
        public ISwitchable Switcher { get; set; }

        public IHeatable Heater { get; set; }

        public string Location { get; set; }

        public HeatComponent(string name, string location, ISwitchable switcher, IHeatable heater):base(name)
        {
            this.Switcher = switcher;
            this.Heater = heater;
            this.Location = location;
        }
    }
}
