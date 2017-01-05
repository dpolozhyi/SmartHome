namespace SmartHome.Components.Interfaces
{
    public interface IColdable
    {
        void SetTemperature(int degrees);

        int GetCurrentTemperature();
    }
}
