using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Get();

        void Insert(T entity);

        void Update(T entity, Guid id);

        void Delete(Guid id);

        void Save();
    }
}
