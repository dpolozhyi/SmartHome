using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using SmartHome.Components.Components;
using SmartHome.Components.Devices;
using SmartHome.Components.Interfaces;
using SmartHome.Components.Modules;
using System.Configuration;

namespace SmartHome.DAL.DBContexts
{
    public class MongoContext
    {
        private static MongoClient client;

        static MongoContext()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MongoDB"].ConnectionString;
            client = new MongoClient(connectionString);
            RegisterClasses();
        }

        public MongoContext()
        {
            
        }

        public IMongoDatabase GetDB(string name)
        {
            return client.GetDatabase(name);
        }

        protected static void RegisterClasses()
        {
            BsonClassMap.RegisterClassMap<Component>(cm =>
            {
                cm.AutoMap();
                cm.SetIsRootClass(true);
            });


            BsonClassMap.RegisterClassMap<AudioComponent>(cm =>
            {
                cm.AutoMap();
            });
            BsonClassMap.RegisterClassMap<HeatComponent>(cm =>
            {
                cm.AutoMap();
            });
            BsonClassMap.RegisterClassMap<MediaComponent>(cm =>
            {
                cm.AutoMap();
            });


            BsonClassMap.RegisterClassMap<Alarm>(cm =>
            {
                cm.AutoMap();
            });
            BsonClassMap.RegisterClassMap<Boiler>(cm =>
            {
                cm.AutoMap();
            });
            BsonClassMap.RegisterClassMap<Recorder>(cm =>
            {
                cm.AutoMap();
            });
            BsonClassMap.RegisterClassMap<TV>(cm =>
            {
                cm.AutoMap();
            });


            BsonClassMap.RegisterClassMap<Brighter>(cm =>
            {
                cm.AutoMap();
                cm.MapProperty("Brightness");
                cm.MapProperty("MinBrightness");
                cm.MapProperty("MaxBrightness");
            });
            BsonClassMap.RegisterClassMap<Channeler>(cm =>
            {
                cm.AutoMap();
                cm.MapProperty("CurrentChannel");
                cm.MapProperty("Channels");
            });
            BsonClassMap.RegisterClassMap<Heater>(cm =>
            {
                cm.AutoMap();
                cm.MapProperty("Temperature");
                cm.MapProperty("MinTemperature");
                cm.MapProperty("MaxTemperature");
            });
            BsonClassMap.RegisterClassMap<Switcher>(cm =>
            {
                cm.AutoMap();
                cm.MapProperty("Condition");
            });
            BsonClassMap.RegisterClassMap<Volumer>(cm =>
            {
                cm.AutoMap();
                cm.MapProperty("Volume");
                cm.MapProperty("MinVolume");
                cm.MapProperty("MaxVolume");
            });
        }
    }
}
