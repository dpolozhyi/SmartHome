using Ninject.Modules;
using SmartHome.Components.Interfaces;
using SmartHome.Components.Components;

namespace SmartHome.ConsoleTest
{
    public class ComponentNinjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<ISwitchable>().To<Switcher>();
            this.Bind<ISoundable>().To<Volumer>();
            this.Bind<IBrightable>().To<Brighter>();
            this.Bind<IChannable>().To<Channeler>();
        }
    }
}
