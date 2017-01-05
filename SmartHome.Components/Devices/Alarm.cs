using SmartHome.Components.Components;
using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Devices
{
    public class Alarm : AudioComponent
    {
        public Alarm(string name, string location, ISwitchable switcher, ISoundable volumer):base(name, location, switcher, volumer)
        {
        }

        public void TurnOn()
        {
            Switcher.SwitchOn();
        }

        public void TurnOff()
        {
            Switcher.SwitchOff();
        }

        public bool IsOn()
        {
            return Switcher.IsOn();
        }
    }
}
