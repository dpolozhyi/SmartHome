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
    public class AudioService
    {
        private IUnitOfWork unit;

        public AudioService() : this(new UnitOfWork(new MongoContext()))
        {

        }

        public AudioService(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public IEnumerable<AudioViewModel> GetAll()
        {
            List<AudioViewModel> audioList = new List<AudioViewModel>();
            List<AudioComponent> auidoComponents = unit.GetRepository<AudioComponent>().Get().ToList();

            foreach (var sounder in auidoComponents)
            {
                audioList.Add(Mapper.Map<AudioViewModel>(sounder));
            }
            return audioList;
        }

        public bool AddItem(AudioViewModel audioDevice)
        {
            switch (audioDevice.TypeName.ToLower())
            {
                case "alarm":
                    {
                        unit.GetRepository<Alarm>().Insert(Mapper.Map<Alarm>(audioDevice));
                        break;
                    }
                case "recorder":
                    {
                        unit.GetRepository<Recorder>().Insert(Mapper.Map<Recorder>(audioDevice));
                        break;
                    }
            }
            return true;
        }

        public bool EditItem(AudioViewModel audioDevice)
        {
            Alarm b = Mapper.Map<Alarm>(audioDevice);
            unit.GetRepository<Alarm>().Update(b, b.Id);
            return true;
        }

        public bool DeleteItem(Guid id)
        {
            unit.GetRepository<Alarm>().Delete(id);
            return true;
        }

        public IEnumerable<string> GetTypesList()
        {
            return new List<string>() { "Alarm", "Recorder" };
        }
    }
}
