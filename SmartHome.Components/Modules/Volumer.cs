using MongoDB.Bson;
using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Modules
{
    public class Volumer : ISoundable, IEntity
    {
        public ObjectId Id { get; set; }

        private int Volume { get; set; }

        private int MinVolume { get; set; }

        private int MaxVolume { get; set; }

        public Volumer(int minVolume = 0, int maxVolume = 100)
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
            }
            else
            {
                this.MinVolume = 0;
                this.MaxVolume = 100;
            }
        }

        public void VolumeUp()
        {
            if(this.Volume<100)
            {
                this.Volume++;
            }
        }

        public void VolumeDown()
        {
            if(this.Volume>0)
            {
                this.Volume--;
            }
        }

        public bool SetVolume(int volume)
        {
            if(volume>=this.MinVolume && volume<=this.MaxVolume)
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
    }
}
