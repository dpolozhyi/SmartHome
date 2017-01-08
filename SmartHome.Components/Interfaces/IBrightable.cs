namespace SmartHome.Components.Interfaces
{
    public interface IBrightable
    {
        void BrightnessUp();

        void BrightnessDown();

        bool SetBrightness(int brightness);
    }
}
