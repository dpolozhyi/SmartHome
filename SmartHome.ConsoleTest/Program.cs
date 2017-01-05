using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartHome.Components.ClassFactory;
using SmartHome.Components.Devices;
using SmartHome.Components.Interfaces;
using SmartHome.Components.Components;
using Ninject;
using Ninject.Injection;
using Ninject.Parameters;

namespace SmartHome.ConsoleTest
{
    class Program
    {
        public static IKernel AppKernel;

        static void Main(string[] args)
        {
            AppKernel = new StandardKernel(new ComponentNinjectModule());
            Switcher switcher = new Switcher();
            Volumer volumer = new Volumer();
            //Alarm alarm = new Alarm("MyAlarm",switcher, volumer);

            //var alarm = AppKernel.Get<Alarm>(new ConstructorArgument("name", "NinjectAlarm"));
            IDeviceFactory<Alarm> factory = new DeviceFactory<Alarm>(AppKernel);
            var alarm = factory.Create("MyNinjectAlarm", "Entry Door") as Alarm;

            Console.WriteLine(alarm.IsOn());
            alarm.TurnOn();
            Console.WriteLine(alarm.IsOn());
            alarm.TurnOff();
            Console.WriteLine(alarm.IsOn());
            Console.WriteLine(alarm.Name);
            Console.WriteLine(alarm.Location);

            Console.WriteLine();

            IDeviceFactory<TV> tvfactory = new DeviceFactory<TV>(AppKernel);
            var tv = tvfactory.Create("MyNinjectTV", "hall");
            Console.WriteLine(tv.IsOn());
            tv.TurnOn();
            Console.WriteLine(tv.IsOn());
            tv.TurnOff();
            Console.WriteLine(tv.IsOn());
            Console.WriteLine(tv.Name);
            Console.WriteLine(tv.Location);
            var clist = tv.GetChannelList();
            foreach(var c in clist)
            {
                Console.WriteLine(c);
            }
        }
    }
}
