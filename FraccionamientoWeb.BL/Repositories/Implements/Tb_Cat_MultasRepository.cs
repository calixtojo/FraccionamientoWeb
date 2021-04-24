using FraccionamientoWeb.BL.Data;
using FraccionamientoWeb.BL.Models;

namespace FraccionamientoWeb.BL.Repositories.Implements
{
    public class Tb_Cat_MultasRepository:GenericRepository<Tb_Cat_Multas>
    {
        public Tb_Cat_MultasRepository(FraccionamientoContext fraccionamientoContext):base(fraccionamientoContext)
        {

        }
    }
}
