﻿using Microsoft.Owin;
using Owin;
using SmartHome.BL.Automapper;

[assembly: OwinStartupAttribute(typeof(SmartHome.WEB.Startup))]
namespace SmartHome.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            AutoMapperConfig.Configure();
        }
    }
}
