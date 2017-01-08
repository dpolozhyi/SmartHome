namespace SmartHome.Components.Interfaces
{
    public interface ISoundable
    {
        void VolumeUp();

        void VolumeDown();

        bool SetVolume(int volume);

        int GetCurrentVolume();
    }
}
