using FraccionamientoWeb.BL.Models;
using FraccionamientoWeb.BL.Data;

namespace FraccionamientoWeb.BL.Repositories.Implements
{
    public class Tb_CobrosRepository:GenericRepository<Tb_Cobros>
    {
        public Tb_CobrosRepository(FraccionamientoContext fraccionamientoContext) : base(fraccionamientoContext)
        {

        }
    }
}
