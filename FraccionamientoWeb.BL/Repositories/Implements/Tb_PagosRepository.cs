using FraccionamientoWeb.BL.Data;
using FraccionamientoWeb.BL.Models;

namespace FraccionamientoWeb.BL.Repositories.Implements
{
    public class Tb_PagosRepository: GenericRepository<Tb_Pagos>
    {
        public Tb_PagosRepository(FraccionamientoContext fraccionamientoContext) : base(fraccionamientoContext)
        {

        }
    }
}
