using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Components
{
    public abstract class ImageComponent : Component, IThing
    {
        protected ISwitchable Switcher { get; set; }
        
        protected IBrightable Brighter { get; set; }

        public string Location { get; set; }
        
        public ImageComponent(string name, string location, ISwitchable switcher, IBrightable brighter):base(name)
        {
            this.Switcher = switcher;
            this.Brighter = brighter;
            this.Location = location;
        } 
    }
}
