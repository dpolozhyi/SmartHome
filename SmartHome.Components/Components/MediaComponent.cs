using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Components
{
    public abstract class MediaComponent : Component, IThing
    {
        protected ISwitchable Switcher { get; set; }

        protected ISoundable Volumer { get; set; }

        protected IBrightable Brighter { get; set; }

        protected IChannable Channeler { get; set; }

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
