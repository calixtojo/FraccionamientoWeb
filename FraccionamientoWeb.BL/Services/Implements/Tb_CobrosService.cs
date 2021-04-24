using FraccionamientoWeb.BL.Repositories;
using FraccionamientoWeb.BL.Models;
namespace FraccionamientoWeb.BL.Services.Implements
{
    public class Tb_CobrosService:GenericService<Tb_Cobros>
    {
        public Tb_CobrosService(ITb_CobrosRepository tb_CobrosRepository):base (tb_CobrosRepository)
        {

        }
    }
}
