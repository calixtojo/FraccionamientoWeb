using FraccionamientoWeb.BL.Models;
using FraccionamientoWeb.BL.Repositories;

namespace FraccionamientoWeb.BL.Services.Implements
{
    public class Tb_Cat_Area_ComunService : GenericService<Tb_Cat_Area_Comun>,ITb_Cat_Area_ComunService
    {
        public Tb_Cat_Area_ComunService(ITb_Cat_Area_ComunRepository tb_Cat_Area_ComunRepository):base(tb_Cat_Area_ComunRepository)
        {

        }
    }
}
