using System.Collections.Generic;
using System.Data.Entity;
using SmartHome.DAL.DBContext;
using SmartHome.DAL.Interfaces;
using System.Linq;
using SmartHome.Components.Components;

namespace SmartHome.DAL.Repositories
{
    public class EFRepository<T> : IRepository<T> where T : class
    {
        private EFContext context;

        public EFRepository(EFContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> Get()
        {
            return context.Set<T>();
        }

        public void Insert(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            context.Set<T>().Attach(entity);
        }

        public void Delete(int id)
        {
            T entity = context.Set<T>().Find(id);
            context.Set<T>().Remove(entity);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
