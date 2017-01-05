using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Components
{
    public class Volumer : ISoundable
    {
        protected int Volume { get; set; }

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
            if(volume>=1 && volume<=100)
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
