using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using AutoMapper;
using FraccionamientoWeb.BL.Data;
using FraccionamientoWeb.BL.DTOs;
using FraccionamientoWeb.BL.Repositories.Implements;
using FraccionamientoWeb.BL.Services.Implements;

namespace FraccionamientoWeb.WebAPI.Controllers
{
    public class FraccionamientoCatalogController : ApiController
    {

        private readonly IMapper mapper;
        /// <summary>
        /// Servicios para consultar a la base de datos
        /// </summary>
        private readonly Tb_Cat_Area_ComunService tb_Cat_Area_ComunService = new Tb_Cat_Area_ComunService(new Tb_Cat_Area_ComunRepository(FraccionamientoContext.Create()));
    
        public FraccionamientoCatalogController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }
    

        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var cat_areas_comun = await tb_Cat_Area_ComunService.GetAll();
            var cat_areas_comunDTO = cat_areas_comun.Select(x => mapper.Map<Tb_Cat_Area_ComunDTO>(x));
                return Ok(cat_areas_comunDTO);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var cat_area_comun = await tb_Cat_Area_ComunService.GetById(id);

            if (cat_area_comun == null)
            {
                return NotFound();
            }
            else
            {
                var cat_area_comunDTO = mapper.Map<Tb_Cat_Area_ComunDTO>(cat_area_comun);
                return Ok(cat_area_comunDTO);
            }
            
        }
    }
}
