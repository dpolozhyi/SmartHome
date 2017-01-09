using AutoMapper;
using SmartHome.BL.DTO;
using SmartHome.Components.Components;
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
    public class HeatService
    {
        private IUnitOfWork unit;

        public HeatService():this(new UnitOfWork(new MongoContext()))
        {
            
        }

        public HeatService(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public IEnumerable<HeatViewModel> GetAll()
        {
            List<HeatViewModel> heatList = new List<HeatViewModel>();
            List<HeatComponent> heatComponents =  unit.GetRepository<HeatComponent>().Get().ToList();

            foreach(var heat in heatComponents)
            {
                heatList.Add(Mapper.Map<HeatViewModel>(heat));
            }
            return heatList;
        }

        public bool AddItem(HeatViewModel boiler)
        {
            unit.GetRepository<Boiler>().Insert(Mapper.Map<Boiler>(boiler));
            return true;
        }

        public bool EditItem(HeatViewModel boiler)
        {
            Boiler b = Mapper.Map<Boiler>(boiler);
            unit.GetRepository<Boiler>().Update(b, b.Id);
            return true;
        }

        public bool DeleteItem(Guid id)
        {
            unit.GetRepository<Boiler>().Delete(id);
            return true;
        }
    }
}
