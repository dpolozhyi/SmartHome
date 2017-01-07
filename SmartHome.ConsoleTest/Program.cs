using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartHome.BL.ClassFactories;
using SmartHome.BL.NinjectModules;
using SmartHome.Components.Adapters;
using SmartHome.Components.Components;
using SmartHome.Components.Devices;
using SmartHome.Components.Interfaces;
using Ninject;
using SmartHome.DAL.DBContext;
using SmartHome.DAL.Interfaces;
using SmartHome.DAL.Repositories;

namespace SmartHome.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel(new ComponentNinjectModule());
            DeviceFactory<Alarm> factory = new DeviceFactory<Alarm>(kernel);
            Alarm newTV = factory.Create("MyNewAlarm", "Hall");
            IRepository<Alarm> repo = new EFRepository<Alarm>(new EFContext());
            IRepository<SwitchableAdapter> repo1 = new EFRepository<SwitchableAdapter>(new EFContext());
            IRepository<SoundableAdapter> repo2 = new EFRepository<SoundableAdapter>(new EFContext());
            /*repo.Insert(newTV);
            repo1.Insert(new SwitchableAdapter(newTV.Switcher));
            repo2.Insert(new SoundableAdapter(newTV.Volumer));
            repo.Save();
            repo1.Save();
            repo2.Save();*/
            Alarm alarm = repo.Get().First();
            alarm.Switcher = repo1.Get().Select(i => i.Switcher).First();
            alarm.Volumer = repo2.Get().Select(i => i.Volumer).First();
            Console.WriteLine();

            DeviceFactory<Boiler> bfactory = new DeviceFactory<Boiler>(kernel);
            Boiler b = bfactory.Create("MyBoiler", "Bath");
            /*repo.Insert(newTV);
            repo.Save();*/
            /*TV yolotv = repo.Get().OfType<TV>().First();
            Console.WriteLine("{0}\n{1}", yolotv.Name, yolotv.Location);*/
        }
    }
}
