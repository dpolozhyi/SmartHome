using Ninject;
using Ninject.Parameters;
using SmartHome.BL.Interfaces;
using SmartHome.Components.Components;

namespace SmartHome.BL.ClassFactories
{
    public class DeviceFactory : IDeviceFactory
    {
        private readonly IKernel kernel;

        public DeviceFactory(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public T Create<T>(string name, string location) where T : Component
        {
            return kernel.Get<T>(new ConstructorArgument("name", name), new ConstructorArgument("location", location));
        }
    }
}
