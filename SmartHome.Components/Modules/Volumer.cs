using SmartHome.Components.Interfaces;
using System;

namespace SmartHome.Components.Modules
{
    public class Volumer : ISoundable, IEntity
    {
        public Guid Id { get; set; }

        private int Volume { get; set; }

        private int MinVolume { get; set; }

        private int MaxVolume { get; set; }

        public Volumer(int curVolume = 50, int minVolume = 0, int maxVolume = 100)
        {
            if (minVolume < maxVolume)
            {
                if (minVolume >= 0)
                {
                    this.MinVolume = minVolume;
                }
                else
                {
                    this.MinVolume = 0;
                }

                if (maxVolume <= 160)
                {
                    this.MaxVolume = maxVolume;
                }
                else
                {
                    this.MaxVolume = 100;
                }

                if (curVolume >= minVolume && curVolume <= maxVolume)
                {
                    this.Volume = curVolume;
                }
                else
                {
                    this.Volume = (this.MinVolume + this.MaxVolume) / 2;
                }
            }
            else
            {
                this.MinVolume = 0;
                this.MaxVolume = 100;
                this.Volume = (this.MinVolume + this.MaxVolume) / 2;
            }
        }

        public bool SetVolume(int volume)
        {
            if (volume >= this.MinVolume && volume <= this.MaxVolume)
            {
                this.Volume = volume;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetCurrentVolume()
        {
            return this.Volume;
        }

        public int GetMinVolume()
        {
            return this.MinVolume;
        }

        public int GetMaxVolume()
        {
            return this.MaxVolume;
        }
    }
}
