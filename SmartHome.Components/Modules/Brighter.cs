using MongoDB.Bson;
using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Modules
{
    public class Brighter : IBrightable, IEntity
    {
        public ObjectId Id { get; set; }

        private int Brightness { get; set; }

        private int MinBrightness { get; set; }

        private int MaxBrightness { get; set; }

        public Brighter(int minBrightness, int maxBrightness)
        {
            if (minBrightness < maxBrightness)
            {
                if (minBrightness >= 0)
                {
                    this.MinBrightness = minBrightness;
                }
                else
                {
                    this.MinBrightness = 0;
                }

                if (maxBrightness <= 100)
                {
                    this.MaxBrightness = maxBrightness;
                }
                else
                {
                    this.MaxBrightness = 100;
                }
            }
            else
            {
                this.MinBrightness = 0;
                this.MaxBrightness = 100;
            }
        }
        public void BrightnessUp()
        {
            if (this.Brightness < this.MaxBrightness)
            {
                this.Brightness++;
            }
        }

        public void BrightnessDown()
        {
            if (this.Brightness > this.MinBrightness)
            {
                this.Brightness--;
            }
        }

        public bool SetBrightness(int brightness)
        {
            if (brightness>=this.MinBrightness && brightness<=this.MaxBrightness)
            {
                this.Brightness = brightness;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
