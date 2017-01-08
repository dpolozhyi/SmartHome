using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartHome.BL.ClassFactories;
using SmartHome.BL.NinjectModules;
using SmartHome.Components.Components;
using SmartHome.Components.Devices;
using SmartHome.Components.Interfaces;
using Ninject;
using SmartHome.DAL.DBContexts;
using SmartHome.DAL.Interfaces;
using SmartHome.DAL.Repositories;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Serializers;
using System.Configuration;
using SmartHome.Components.Modules;
using SmartHome.BL.Interfaces;

namespace SmartHome.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnitOfWork unit = new UnitOfWork(new MongoContext());
            IKernel kernel = new StandardKernel(new ComponentNinjectModule());
            IDeviceFactory factory = new DeviceFactory(kernel);
            Boiler b = factory.Create<Boiler>("MyNewBoiler", "Bath");
            Boiler b2 = factory.Create<Boiler>("MyNewMiniBoiler", "Kitchen");
            TV newTV = factory.Create<TV>("BrandNewTv", "Hall");
            Alarm a = factory.Create<Alarm>("NewAlarm", "InDoor");
            /*unit.GetRepository<Boiler>().Insert(b);
            unit.GetRepository<Boiler>().Insert(b2);
            unit.GetRepository<TV>().Insert(newTV);
            unit.GetRepository<Alarm>().Insert(a);*/
            Random rnd = new Random();
            List<Boiler> blist = unit.GetRepository<Boiler>().Get().ToList();
            foreach (var bo in blist)
            {
                /*bo.Heater.SetTemperature(rnd.Next(35, 100));
                unit.GetRepository<Boiler>().Update(bo, bo.Id);*/
                Console.WriteLine("Id={0}\nName={1}\nTemp={2}\n",bo.Id,bo.Name,bo.Heater.GetCurrentTemperature());
            }
            /*List<Boiler> kb = blist.Where(n => n.Location == "Kitchen").Select(n => n).ToList();
            for(int i=0; i<kb.Count; i++)
            {
                kb[i].Name = "KitchenBoiler";
                repo.Update(kb[i], kb[i].Id);
            }*/
        }
    }
}
