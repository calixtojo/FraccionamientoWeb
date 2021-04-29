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
using FraccionamientoWeb.BL.Models;
using FraccionamientoWeb.BL.Repositories.Implements;
using FraccionamientoWeb.BL.Services.Implements;


namespace FraccionamientoWeb.WebAPI.Controllers
{
    [RoutePrefix("api/CatAreaComun")]
    public class CatAreaComunController : ApiController
    {

        /// <summary>
        /// Mappeo de DTO desde modelo de datos
        /// </summary>
        private readonly IMapper mapper;
        /// <summary>
        /// Servicios para consultar a la base de datos Tabla tb_cat_area_comun
        /// </summary>
        private readonly Tb_Cat_Area_ComunService tb_Cat_Area_ComunService = new Tb_Cat_Area_ComunService(new Tb_Cat_Area_ComunRepository(FraccionamientoContext.Create()));
    
        public CatAreaComunController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }


        /// <summary>
        ///     Obtiene catalogo Cat_Area_Comun
        /// </summary>
        [HttpGet]
        public async Task<IHttpActionResult> GetAllCatAreaComun()
        {
            var cat_areas_comun = await tb_Cat_Area_ComunService.GetAll();
            var cat_areas_comunDTO = cat_areas_comun.Select(x => mapper.Map<Tb_Cat_Area_ComunDTO>(x));
                return Ok(cat_areas_comunDTO);
        }


        /// <summary>
        ///  Obtiene Registro Cat_Area_Comun Por ID
        /// </summary>
        [HttpGet]
        public async Task<IHttpActionResult> GetByIdCatAreaComun(int id)
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

        /// <summary>
        /// Inserta un nuevo registro en la tabla Tb_Cat_Area_Comun
        /// </summary>
        /// <param name="tb_Cat_Area_ComunDTO"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IHttpActionResult> InsertCatAreaComun(Tb_Cat_Area_ComunDTO tb_Cat_Area_ComunDTO)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var flag = await tb_Cat_Area_ComunService.GetById(tb_Cat_Area_ComunDTO.Id_Area_Comun); //Validacion de registro exista en DB

            if (flag == null)
            {
                return NotFound();

            }
            else
            {
                var cat_Area_Comun = mapper.Map<Tb_Cat_Area_Comun>(tb_Cat_Area_ComunDTO);

                try
                {
                    cat_Area_Comun = await tb_Cat_Area_ComunService.Insert(cat_Area_Comun);
                    return Ok(cat_Area_Comun);
                }
                catch (Exception ex)
                {

                    return InternalServerError(ex);
                }

                
            }
        }


        /// <summary>
        /// Metodo para actualizar registro en tabla Tb_Cat_Area_Comun
        /// </summary>
        /// <param name="tb_Cat_Area_ComunDTO"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IHttpActionResult> UpdateCatAreaComun(Tb_Cat_Area_ComunDTO tb_Cat_Area_ComunDTO, int id)
        {
            if(!ModelState.IsValid) //Validacion del modelo
            {
                return BadRequest(ModelState);
            }

            if(tb_Cat_Area_ComunDTO.Id_Area_Comun != id) //Validacion por Id
            {
                return BadRequest();

            }

            var flag = await tb_Cat_Area_ComunService.GetById(id); //Validacion de registro exista en DB
           
            if (flag == null)
            {
                return NotFound();

            }

            try
            {
                var cat_Area_Comun = mapper.Map<Tb_Cat_Area_Comun>(tb_Cat_Area_ComunDTO);
                cat_Area_Comun = await tb_Cat_Area_ComunService.Update(cat_Area_Comun); //Metodo que actualiza registro
                return Ok(cat_Area_Comun);

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }



        ///// <summary>
        ///// Metodo para eliminar un registro de la tabla CatAreaComun
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //[HttpDelete]
        //public async Task<IHttpActionResult> DeleteCatAreaComun(int id)
        //{
        //    var flag = await tb_Cat_Area_ComunService.GetById(id); //Validacion de registro exista en DB

        //    if (flag == null)
        //    {
        //        return NotFound();

        //    }

        //    try
        //    {
        //        await tb_Cat_Area_ComunService.Delete(id);
        //        return Ok();

        //    }
        //    catch (Exception ex)
        //    {

        //        return InternalServerError(ex);
        //    }
        //    return Ok();
        //}

    }
}
