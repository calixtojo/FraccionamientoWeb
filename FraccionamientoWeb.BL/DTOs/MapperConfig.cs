using FraccionamientoWeb.BL.Models;
using FraccionamientoWeb.BL.DTOs;
using AutoMapper;

namespace FraccionamientoWeb.BL.DTOs
{
    public class MapperConfig
    {
        public static MapperConfiguration MapperConfiguration()
        {
            return new MapperConfiguration(cfg =>
            {
                //Para metodos POST y PUT
                cfg.CreateMap<Tb_Cat_Area_Comun,Tb_Cat_Area_ComunDTO>();
                cfg.CreateMap<Tb_Cat_Area_ComunDTO,Tb_Cat_Area_Comun>();

            });
        }
    }
}
