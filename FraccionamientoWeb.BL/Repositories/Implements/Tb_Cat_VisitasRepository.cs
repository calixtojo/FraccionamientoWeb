using FraccionamientoWeb.BL.Models;
using FraccionamientoWeb.BL.Data;

namespace FraccionamientoWeb.BL.Repositories.Implements
{
    public class Tb_Cat_VisitasRepository:GenericRepository<Tb_Cat_Visitas>
    {
        public Tb_Cat_VisitasRepository(FraccionamientoContext fraccionamientoContext) : base(fraccionamientoContext)
        {

        }
    }
}
