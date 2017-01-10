namespace SmartHome.Components.Interfaces
{
    public interface IBrightable
    {
        bool SetBrightness(int brightness);

        int GetCurrentBrightness();

        int GetMinBrightness();

        int GetMaxBrightness();
    }
}
