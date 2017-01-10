using SmartHome.Components.Interfaces;
using System;

namespace SmartHome.Components.Modules
{
    public class Brighter : IBrightable, IEntity
    {
        public Guid Id { get; set; }

        private int Brightness { get; set; }

        private int MinBrightness { get; set; }

        private int MaxBrightness { get; set; }

        public Brighter(int curBrightness = 50, int minBrightness = 0, int maxBrightness = 100)
        {
            if (curBrightness >= minBrightness && curBrightness <= maxBrightness)
            {
                this.MinBrightness = minBrightness;
                this.MaxBrightness = maxBrightness;
                this.Brightness = curBrightness;
            }
        }
        
        public int GetCurrentBrightness()
        {
            return this.Brightness;
        }

        public bool SetBrightness(int brightness)
        {
            if (brightness >= this.MinBrightness && brightness <= this.MaxBrightness)
            {
                this.Brightness = brightness;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetMinBrightness()
        {
            return this.MinBrightness;
        }

        public int GetMaxBrightness()
        {
            return this.MaxBrightness;
        }
    }
}
