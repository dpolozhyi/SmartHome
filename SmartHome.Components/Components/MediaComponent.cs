using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Components
{
    public abstract class MediaComponent : Component, IThing
    {
        public ISwitchable Switcher { get; private set; }

        public ISoundable Volumer { get; private set; }

        public IBrightable Brighter { get; private set; }

        public IChannable Channeler { get; private set; }

        public string Location { get; private set; }

        public MediaComponent(string name, string location, ISwitchable switcher, ISoundable volumer, IBrightable brighter, IChannable channeler) : base(name)
        {
            this.Switcher = switcher;
            this.Volumer = volumer;
            this.Brighter = brighter;
            this.Channeler = channeler;
            this.Location = location;
        }
    }
}
