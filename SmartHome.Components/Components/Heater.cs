using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Components
{
    public class Heater : IHeatable, IEntity
    {
        public int Id { get; set; }

        private int Temperature { get; set; }

        private int MinTemperature { get; set; }

        private int MaxTemperature { get; set; }

        public Heater(int minTemperature, int maxTemperature)
        {
            if (minTemperature < maxTemperature)
            {
                if (minTemperature >= 30)
                {
                    this.MinTemperature = minTemperature;
                }
                else
                {
                    this.MinTemperature = 0;
                }

                if (maxTemperature <= 100)
                {
                    this.MaxTemperature = maxTemperature;
                }
                else
                {
                    this.MaxTemperature = 60;
                }
            }
            else
            {
                this.MinTemperature = 0;
                this.MaxTemperature = 60;
            }
        }

        public bool SetTemperature(int degrees)
        {
            if (degrees >= this.MinTemperature && degrees < this.MaxTemperature)
            {
                this.Temperature = degrees;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetCurrentTemperature()
        {
            return this.Temperature;
        }
    }
}
