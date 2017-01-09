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
            if (minTemperature < maxTemperature)
            {
                if (minTemperature >= 30)
                {
                    this.MinTemperature = minTemperature;
                }
                else
                {
                    this.MinTemperature = 30;
                }

                if (maxTemperature <= 100)
                {
                    this.MaxTemperature = maxTemperature;
                }
                else
                {
                    this.MaxTemperature = 60;
                }

                if (curTemperature < maxTemperature && curTemperature > minTemperature)
                {
                    this.Temperature = curTemperature;
                }
                else
                {
                    this.Temperature = 45;
                }
            }
            else
            {
                this.MinTemperature = 30;
                this.MaxTemperature = 60;
                this.Temperature = 45;
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
