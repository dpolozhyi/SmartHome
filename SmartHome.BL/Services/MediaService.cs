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
    public class MediaService
    {
        private IUnitOfWork unit;

        public MediaService():this(new UnitOfWork(new MongoContext()))
        {

        }

        public MediaService(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public IEnumerable<MediaViewModel> GetAll()
        {
            List<MediaViewModel> mediaList = new List<MediaViewModel>();
            List<MediaComponent> mediaComponents = unit.GetRepository<MediaComponent>().Get().ToList();

            foreach (var media in mediaComponents)
            {
                mediaList.Add(Mapper.Map<MediaViewModel>(media));
            }
            return mediaList;
        }

        public bool AddItem(MediaViewModel mediaDevice)
        {
            unit.GetRepository<TV>().Insert(Mapper.Map<TV>(mediaDevice));
            return true;
        }

        public bool EditItem(MediaViewModel boiler)
        {
            TV mediaDevice = Mapper.Map<TV>(boiler);
            unit.GetRepository<TV>().Update(mediaDevice, mediaDevice.Id);
            return true;
        }

        public bool DeleteItem(Guid id)
        {
            unit.GetRepository<TV>().Delete(id);
            return true;
        }
    }
}
