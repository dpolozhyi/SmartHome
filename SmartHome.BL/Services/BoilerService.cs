using SmartHome.BL.DTO;
using SmartHome.Components.Devices;
using SmartHome.DAL.DBContexts;
using SmartHome.DAL.Interfaces;
using SmartHome.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.BL.Services
{
    public class BoilerService
    {
        private IUnitOfWork unit;

        public BoilerService():this(new UnitOfWork(new MongoContext()))
        {
            
        }

        public BoilerService(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public IEnumerable<BoilerViewModel> GetAll()
        {
            List<BoilerViewModel> bList = new List<BoilerViewModel>();
            List<Boiler> bl =  unit.GetRepository<Boiler>().Get().ToList();
            foreach(var b in bl)
            {
                bList.Add(new BoilerViewModel()
                {
                    Id = b.Id,
                    Condition = b.Switcher.IsOn(),
                    Location = b.Location,
                    Name = b.Name,
                    Temperature = b.Heater.GetCurrentTemperature()
                });
            }
            return bList;
        }
    }
}
