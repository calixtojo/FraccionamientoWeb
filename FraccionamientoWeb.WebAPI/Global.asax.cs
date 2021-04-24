using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using FraccionamientoWeb.BL.DTOs;

namespace FraccionamientoWeb.WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        internal static MapperConfiguration MapperConfiguration { get; set; }
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            ///Mapper Configuracion
            MapperConfiguration = MapperConfig.MapperConfiguration();
        }
    }
}
