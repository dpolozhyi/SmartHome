namespace SmartHome.Components.Interfaces
{
    public interface IHeatable
    {
        bool SetTemperature(int degrees);

        int GetCurrentTemperature();
    }
}
