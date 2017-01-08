using Ninject.Modules;
using SmartHome.Components.Interfaces;
using SmartHome.Components.Modules;

namespace SmartHome.BL.NinjectModules
{
    public class ComponentNinjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<ISwitchable>().To<Switcher>();
            this.Bind<ISoundable>().To<Volumer>();
            this.Bind<IBrightable>().To<Brighter>();
            this.Bind<IChannable>().To<Channeler>();
            this.Bind<IHeatable>().To<Heater>();
        }
    }
}
