using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Components
{
    public class Brighter : IBrightable
    {
        private int brightness;

        public void BrightnessUp()
        {
            if(this.brightness<100)
            {
                brightness++;
            }
        }

        public void BrightnessDown()
        {
            if(this.brightness>0)
            {
                this.brightness--;
            }
        }
    }
}
