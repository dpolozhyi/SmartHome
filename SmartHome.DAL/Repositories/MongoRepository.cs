using System.Collections.Generic;
using SmartHome.DAL.DBContexts;
using SmartHome.DAL.Interfaces;
using System.Linq;
using SmartHome.Components.Components;
using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Configuration;

namespace SmartHome.DAL.Repositories
{
    public class MongoRepository<T> : IRepository<T> where T : class
    {
        private MongoContext context;

        private IMongoDatabase db;

        private IMongoCollection<T> collection;

        public MongoRepository(MongoContext context)
        {
            this.context = context;
            db = context.GetDB(this.GetAppSetting("DbName"));
            collection = db.GetCollection<T>(this.GetAppSetting("DevicesCollection"));
        }

        public string GetAppSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public IQueryable<T> Get()
        {
            return collection.OfType<T>().AsQueryable();
        }

        public void Insert(T entity)
        {
            collection.InsertOne(entity);
        }

        public void Update(T entity, Guid id)
        {
            BsonDocument filter = new BsonDocument("_id", id);
            collection.ReplaceOne(filter, entity);
        }

        public void Delete(Guid id)
        {
            BsonDocument filter = new BsonDocument("_id", id);
            collection.DeleteOne(filter);
        }

        public void Save()
        {
            
        }
    }
}
