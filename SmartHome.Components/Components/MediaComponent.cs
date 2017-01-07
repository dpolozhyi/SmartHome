using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Components
{
    public abstract class MediaComponent : Component, IThing
    {
        public ISwitchable Switcher { get; set; }

        public ISoundable Volumer { get; set; }

        public IBrightable Brighter { get; set; }

        public IChannable Channeler { get; set; }

        public string Location { get; set; }

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
