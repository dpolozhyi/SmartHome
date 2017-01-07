using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Components
{
    public abstract class AudioComponent : Component, IThing
    {
        protected ISwitchable Switcher { get; set; }

        protected ISoundable Volumer { get; set; }

        public string Location { get; set; }

        public AudioComponent(string name, string location, ISwitchable switcher, ISoundable volumer):base(name)
        {
            this.Switcher = switcher;
            this.Volumer = volumer;
            this.Location = location;
        }
    }
}
