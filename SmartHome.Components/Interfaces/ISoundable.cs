namespace SmartHome.Components.Interfaces
{
    public interface ISoundable
    {
        bool SetVolume(int volume);

        int GetCurrentVolume();

        int GetMinVolume();

        int GetMaxVolume();
    }
}
