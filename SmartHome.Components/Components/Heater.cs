using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Components
{
    public class Heater : IHeatable
    {
        private int temperature;

        public bool SetTemperature(int degrees)
        {
            if (degrees > 30 && degrees < 100)
            {
                this.temperature = degrees;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetCurrentTemperature()
        {
            return this.temperature;
        }
    }
}
