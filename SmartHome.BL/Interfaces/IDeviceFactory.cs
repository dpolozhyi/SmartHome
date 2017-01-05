using SmartHome.Components.Components;

namespace SmartHome.BL.Interfaces
{
    public interface IDeviceFactory<T> where T : Component
    {
        T Create(string name, string location);
    }
}
