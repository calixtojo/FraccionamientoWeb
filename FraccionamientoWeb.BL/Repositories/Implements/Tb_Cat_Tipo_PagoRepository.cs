using FraccionamientoWeb.BL.Data;
using FraccionamientoWeb.BL.Models;

namespace FraccionamientoWeb.BL.Repositories.Implements
{
    public class Tb_Cat_Tipo_PagoRepository:GenericRepository<Tb_Cat_Tipo_Pago>
    {
        public Tb_Cat_Tipo_PagoRepository(FraccionamientoContext fraccionamientoContext):base (fraccionamientoContext)
        {

        }
    }
}
