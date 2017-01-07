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
using SmartHome.DAL.DBContext;
using SmartHome.DAL.Interfaces;
using SmartHome.DAL.Repositories;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Serializers;
using System.Configuration;
using SmartHome.Components.Modules;

namespace SmartHome.ConsoleTest
{
    class Program
    {
        public interface ICar
        {
            ObjectId Id { get; set; }

            void SetSpeed(int speed);

            int GetSpeed();
        }

        public class Car : ICar
        {
            public ObjectId Id { get; set; }

            private int Speed { get; set; }

            public Car(int speed = 5)
            {
                this.Speed = speed;
            }

            public void SetSpeed(int speed)
            {
                this.Speed = speed;
            }

            public int GetSpeed()
            {
                return this.Speed;
            }
        }

        public class SuperCar : ICar
        {
            public ObjectId Id { get; set; }

            private int Speed { get; set; }

            private string Coffee { get; set; }

            public SuperCar(int speed = 155)
            {
                this.Speed = speed;
                this.Coffee = "Latte";
            }

            public void ChangeCoffee(string name)
            {
                this.Coffee = name;
            }

            public void SetSpeed(int speed)
            {
                this.Speed = speed;
            }

            public int GetSpeed()
            {
                return this.Speed;
            }
        }

        public class Person
        {
            public ObjectId Id { get; set; }

            public string Name { get; private set; }

            //[BsonSerializer(typeof(ImpliedImplementationInterfaceSerializer<ICar, Car>))]
            public ICar Car { get; private set; }

            [BsonConstructor]
            public Person(string name, ICar car)
            {
                this.Name = name;
                this.Car = car;
            }
        }

        public class HeaterDevil : IHeatable, IEntity
        {
            public ObjectId Id { get; set; }

            private int Temperature { get; set; }

            public HeaterDevil()
            {
                
            }

            public bool SetTemperature(int degrees)
            {
                Temperature = degrees;
                return true;
            }

            public int GetCurrentTemperature()
            {
                return 666;
            }
        }

        static void Main(string[] args)
        {


            /*BsonClassMap.RegisterClassMap<Person>(cm =>
            {
                cm.AutoMap();
            });
            BsonClassMap.RegisterClassMap<Car>(cm =>
            {
                cm.AutoMap();
                cm.MapProperty("Speed");
            });
            BsonClassMap.RegisterClassMap<SuperCar>(cm =>
            {
                cm.AutoMap();
                cm.MapProperty("Speed");
            });
            MongoClient client = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase db = client.GetDatabase("smarthome");
            Car car = new Car(11);
            Person per = new Person("Loh", car);
            SuperCar car2 = new SuperCar(210);
            car2.ChangeCoffee("Mocachinp");
            Person per2 = new Person("Shumakher", car2);
            var filter = new BsonDocument();
            var pcollection = db.GetCollection<Person>("people");
            /*pcollection.InsertOne(per);
            pcollection.InsertOne(per2);*/

            //pcollection.DeleteMany(filter);
            /*List<Person> personList = db.GetCollection<Person>("people").Aggregate().ToList();
            foreach (var p in personList)
            {
               Console.WriteLine("id={0}\nName = {1}\nCarSpeed = {2}\n", p.Id, p.Name, p.Car.GetSpeed());
            }*/

            /*foreach (var c in carList)
            {
                Console.WriteLine("id={0}\nSpeed = {1}\n", c.Id, c.GetSpeed());
            }
            foreach (var s in scarList)
            {
                Console.WriteLine("id={0}\nSpeed = {1}\n", s.Id, s.GetSpeed());
            }*/

            IKernel kernel = new StandardKernel(new ComponentNinjectModule());
            DeviceFactory<Boiler> bfactory = new DeviceFactory<Boiler>(kernel);
            Boiler b = bfactory.Create("My2017Boiler", "BathC");
            //b.Heater.SetTemperature(53);
            b.Switcher.SwitchOn();
            //Console.WriteLine("Temp = {0}", b.Heater.GetCurrentTemperature());

            BsonClassMap.RegisterClassMap<Component>(cm =>
            {
                cm.AutoMap();
                //cm.SetIsRootClass(true);
            });

            BsonClassMap.RegisterClassMap<HeatComponent>(cm =>
            {
                cm.AutoMap();
            });

            BsonClassMap.RegisterClassMap<Switcher>(cm =>
            {
                cm.AutoMap();
                cm.MapProperty("Condition");
            });

            BsonClassMap.RegisterClassMap<Heater>(cm =>
            {
                cm.AutoMap();
                cm.MapProperty("Temperature");
                cm.MapProperty("MinTemperature");
                cm.MapProperty("MaxTemperature");
            });

            BsonClassMap.RegisterClassMap<HeaterDevil>(cm =>
            {
                cm.AutoMap();
                cm.MapProperty("Temperature");
            });

            BsonClassMap.RegisterClassMap<Boiler>(cm =>
            {
                cm.AutoMap();
            });
            MongoClient client = new MongoClient(ConfigurationManager.ConnectionStrings["MongoDB"].ConnectionString);
            IMongoDatabase db = client.GetDatabase("smarthome");
            var bcollection = db.GetCollection<Component>("boilers");

            //bcollection.InsertOne(b);
            //bcollection.DeleteMany(new BsonDocument());

            
            List<Boiler> personList = db.GetCollection<Component>("boilers").OfType<Boiler>().Aggregate().ToList();
            foreach (var p in personList)
            {
                Console.WriteLine("id={0}\nLocation={1}\nTemp={2}\nSwitchOn={3}\n", p.Id, p.Location, p.Heater.GetCurrentTemperature(), p.Switcher.IsOn());
            }

            personList[0].Switcher.SwitchOff();
            //personList[0].Heater = new HeaterDevil();
            personList[0].Heater.SetTemperature(36);
            var filter = new BsonDocument("_id", personList[0].Id); ;
            var update = new BsonDocument(personList[0].ToBsonDocument());
            /*BsonElement filter2;
            update.TryGetElement("_t", out filter2);
            var filter3 = new BsonDocument("_t", filter2.Value.ToString());*/
            //bcollection.ReplaceOne(filter, personList[0]);
            /*DeviceFactory<Alarm> factory = new DeviceFactory<Alarm>(kernel);
            Alarm newTV = factory.Create("MyNewAlarm", "Hall");
            IRepository<Alarm> repo = new EFRepository<Alarm>(new EFContext());
            IRepository<SwitchableAdapter> repo1 = new EFRepository<SwitchableAdapter>(new EFContext());
            IRepository<SoundableAdapter> repo2 = new EFRepository<SoundableAdapter>(new EFContext());*/
            /*repo.Insert(newTV);
            repo1.Insert(new SwitchableAdapter(newTV.Switcher));
            repo2.Insert(new SoundableAdapter(newTV.Volumer));
            repo.Save();
            repo1.Save();
            repo2.Save();*/
            /*Alarm alarm = repo.Get().First();
            alarm.Switcher = repo1.Get().Select(i => i.Switcher).First();
            alarm.Volumer = repo2.Get().Select(i => i.Volumer).First();
            Console.WriteLine();*/

            /*IRepository<Boiler> brepo = new EFRepository<Boiler>(new EFContext());
            DeviceFactory<Boiler> bfactory = new DeviceFactory<Boiler>(kernel);
            Boiler b = bfactory.Create("My2017Boiler", "BathC");
            b.Heater.SetTemperature(53);
            Console.WriteLine("Temp = {0}", b.Heater.GetCurrentTemperature());
            brepo.Insert(b);
            brepo.Save();
            List<Boiler> sb = brepo.Get().ToList();
            foreach(var s in sb)
            {
                Console.WriteLine("Temp = {0}", s.Heater.GetCurrentTemperature());
            }*/

            //IEnumerable<Boiler>
            /*TV yolotv = repo.Get().OfType<TV>().First();
            Console.WriteLine("{0}\n{1}", yolotv.Name, yolotv.Location);*/
        }
    }
}
