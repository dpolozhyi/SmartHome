using SmartHome.Components.Interfaces;
using System;

namespace SmartHome.Components.Modules
{
    public class Heater : IHeatable, IEntity
    {
        public Guid Id { get; set; }

        private int Temperature { get; set; }

        private int MinTemperature { get; set; }

        private int MaxTemperature { get; set; }

        public Heater(int curTemperature = 45, int minTemperature = 30, int maxTemperature = 60)
        {
            if (curTemperature >= minTemperature && curTemperature <= maxTemperature)
            {
                this.MinTemperature = minTemperature;
                this.MaxTemperature = maxTemperature;
                this.Temperature = curTemperature;
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

        public int GetMinTemperature()
        {
            return this.MinTemperature;
        }

        public int GetMaxTemperature()
        {
            return this.MaxTemperature;
        }
    }
}
