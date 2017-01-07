using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get();

        void Insert(T entity);

        void Update(T entity);

        void Delete(int id);

        void Save();
    }
}
