using FraccionamientoWeb.BL.Data;
using FraccionamientoWeb.BL.Models; 

namespace FraccionamientoWeb.BL.Repositories.Implements
{
    public class Tb_VisitasRepository: GenericRepository<Tb_Visitas>
    {
        public Tb_VisitasRepository(FraccionamientoContext fraccionamientoContext):base(fraccionamientoContext)
        {

        }
    }
}
