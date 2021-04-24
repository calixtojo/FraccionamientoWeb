using FraccionamientoWeb.BL.Data;
using FraccionamientoWeb.BL.Models;

namespace FraccionamientoWeb.BL.Repositories.Implements
{
    public class Tb_MultasRepository: GenericRepository<Tb_Multas>
    {
        public Tb_MultasRepository(FraccionamientoContext fraccionamientoContext) : base(fraccionamientoContext)
        {

        }
    }
}
