using FraccionamientoWeb.BL.Models;
using FraccionamientoWeb.BL.Data;

namespace FraccionamientoWeb.BL.Repositories.Implements
{
   public class Tb_Reserva_Area_ComunRepository:GenericRepository<Tb_Reserva_Area_Comun>
    {
        public Tb_Reserva_Area_ComunRepository(FraccionamientoContext fraccionamientoContext) : base(fraccionamientoContext)
        {

        }
    }
}
