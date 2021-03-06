﻿using AutoMapper;
using SmartHome.BL.DTO;
using SmartHome.Components.Components;
using SmartHome.Components.Devices;
using SmartHome.Components.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.BL.Automapper
{
    public class MapperProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Boiler, HeatViewModel>()
                .ForMember(x => x.Temperature, opt => opt.MapFrom
                     (y => y.Heater.GetCurrentTemperature()))
                .ForMember(x => x.TypeName, opt => opt.MapFrom(y => y.GetType().Name))
                .ForMember(x => x.MinTemperature, opt => opt.MapFrom(y => y.Heater.GetMinTemperature()))
                .ForMember(x => x.MaxTemperature, opt => opt.MapFrom(y => y.Heater.GetMaxTemperature()))
                .ForMember(x => x.Condition, opt => opt.MapFrom(y => y.Switcher.IsOn()));
            CreateMap<HeatViewModel, Boiler>()
                .ForMember(x => x.Location, opt => opt.MapFrom(y => y.Location))
                .ForMember(x => x.Name, opt => opt.MapFrom(y => y.Name))
                .ForMember(x => x.Heater, opt => opt.MapFrom(y => new Heater(y.Temperature, y.MinTemperature, y.MaxTemperature)))
                .ForMember(x => x.Switcher, opt => opt.MapFrom(y => new Switcher(y.Condition)));

            CreateMap<Alarm, AudioViewModel>()
                .ForMember(x => x.Volume, opt => opt.MapFrom
                     (y => y.Volumer.GetCurrentVolume()))
                .ForMember(x => x.TypeName, opt => opt.MapFrom(y => y.GetType().Name))
                .ForMember(x => x.MinVolume, opt => opt.MapFrom(y => y.Volumer.GetMinVolume()))
                .ForMember(x => x.MaxVolume, opt => opt.MapFrom(y => y.Volumer.GetMaxVolume()))
                .ForMember(x => x.Condition, opt => opt.MapFrom(y => y.Switcher.IsOn()));
            CreateMap<Recorder, AudioViewModel>()
                .ForMember(x => x.Volume, opt => opt.MapFrom
                     (y => y.Volumer.GetCurrentVolume()))
                .ForMember(x => x.TypeName, opt => opt.MapFrom(y => y.GetType().Name))
                .ForMember(x => x.MinVolume, opt => opt.MapFrom(y => y.Volumer.GetMinVolume()))
                .ForMember(x => x.MaxVolume, opt => opt.MapFrom(y => y.Volumer.GetMaxVolume()))
                .ForMember(x => x.Condition, opt => opt.MapFrom(y => y.Switcher.IsOn()));
            CreateMap<AudioViewModel, Alarm>()
               .ForMember(x => x.Location, opt => opt.MapFrom(y => y.Location))
               .ForMember(x => x.Name, opt => opt.MapFrom(y => y.Name))
               .ForMember(x => x.Volumer, opt => opt.MapFrom(y => new Volumer(y.Volume, y.MinVolume, y.MaxVolume)))
               .ForMember(x => x.Switcher, opt => opt.MapFrom(y => new Switcher(y.Condition)));
            CreateMap<AudioViewModel, Recorder>()
               .ForMember(x => x.Location, opt => opt.MapFrom(y => y.Location))
               .ForMember(x => x.Name, opt => opt.MapFrom(y => y.Name))
               .ForMember(x => x.Volumer, opt => opt.MapFrom(y => new Volumer(y.Volume, y.MinVolume, y.MaxVolume)))
               .ForMember(x => x.Switcher, opt => opt.MapFrom(y => new Switcher(y.Condition)));

            CreateMap<TV, MediaViewModel>()
                .ForMember(x => x.Volume, opt => opt.MapFrom
                     (y => y.Volumer.GetCurrentVolume()))
                .ForMember(x => x.TypeName, opt => opt.MapFrom(y => y.GetType().Name))
                .ForMember(x => x.MinVolume, opt => opt.MapFrom(y => y.Volumer.GetMinVolume()))
                .ForMember(x => x.MaxVolume, opt => opt.MapFrom(y => y.Volumer.GetMaxVolume()))
                .ForMember(x => x.Condition, opt => opt.MapFrom(y => y.Switcher.IsOn()))
                .ForMember(x => x.Brightness, opt => opt.MapFrom(y => y.Brighter.GetCurrentBrightness()))
                .ForMember(x => x.MinBrightness, opt => opt.MapFrom(y => y.Brighter.GetMinBrightness()))
                .ForMember(x => x.MaxBrightness, opt => opt.MapFrom(y => y.Brighter.GetMaxBrightness()))
                .ForMember(x => x.CurrentChannel, opt => opt.MapFrom(y => y.Channeler.GetCurrentChannel()))
                .ForMember(x => x.Channels, opt => opt.MapFrom(y => y.Channeler.GetChannelsList()));
            CreateMap<MediaViewModel, TV>()
               .ForMember(x => x.Location, opt => opt.MapFrom(y => y.Location))
               .ForMember(x => x.Name, opt => opt.MapFrom(y => y.Name))
               .ForMember(x => x.Volumer, opt => opt.MapFrom(y => new Volumer(y.Volume, y.MinVolume, y.MaxVolume)))
               .ForMember(x => x.Switcher, opt => opt.MapFrom(y => new Switcher(y.Condition)))
               .ForMember(x => x.Brighter, opt => opt.MapFrom(y => new Brighter(y.Brightness, y.MinBrightness, y.MaxBrightness)))
               .ForMember(x => x.Channeler, opt => opt.MapFrom(y => new Channeler(y.Channels, y.CurrentChannel)));
        }
    }
}
