using SmartHome.DAL.DBContexts;
using SmartHome.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private MongoContext context;

        public UnitOfWork()
        { }

        public UnitOfWork(MongoContext context)
        {
            this.context = context;
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new MongoRepository<T>(context);
        }
    }
}
