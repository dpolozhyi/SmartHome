using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Components
{
    public abstract class AudioComponent : Component, IThing
    {
        public ISwitchable Switcher { get; private set; }

        public ISoundable Volumer { get; private set; }

        public string Location { get; private set; }

        public AudioComponent(string name, string location, ISwitchable switcher, ISoundable volumer):base(name)
        {
            this.Switcher = switcher;
            this.Volumer = volumer;
            this.Location = location;
        }
    }
}
