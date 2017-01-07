using Ninject;
using Ninject.Parameters;
using SmartHome.BL.Interfaces;
using SmartHome.Components.Components;

namespace SmartHome.BL.ClassFactories
{
    public class DeviceFactory<T> : IDeviceFactory<T> where T : Component
    {
        private readonly IKernel kernel;

        public DeviceFactory(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public T Create(string name, string location)
        {
            return kernel.Get<T>(new ConstructorArgument("name", name), new ConstructorArgument("location", location));
        }
    }
}
