using FraccionamientoWeb.BL.Models;
using FraccionamientoWeb.BL.Data;

namespace FraccionamientoWeb.BL.Repositories.Implements
{
    public class Tb_Cat_MontosRepository : GenericRepository<Tb_Cat_Montos>
    {
        public Tb_Cat_MontosRepository(FraccionamientoContext fraccionamientoContext):base(fraccionamientoContext)
        {

        }
    }
}
