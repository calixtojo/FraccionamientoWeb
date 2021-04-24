using FraccionamientoWeb.BL.Models;
using FraccionamientoWeb.BL.Data;

namespace FraccionamientoWeb.BL.Repositories.Implements
{
    public class Tb_EvidenciasRepository:GenericRepository<Tb_Evidencias>
    {
        public Tb_EvidenciasRepository(FraccionamientoContext fraccionamientoContext) : base(fraccionamientoContext)
        {

        }
    }
}
