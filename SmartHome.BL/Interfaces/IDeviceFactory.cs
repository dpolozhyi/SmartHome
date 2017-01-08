using SmartHome.Components.Components;

namespace SmartHome.BL.Interfaces
{
    public interface IDeviceFactory
    {
        T Create<T>(string name, string location) where T : Component;
    }
}
