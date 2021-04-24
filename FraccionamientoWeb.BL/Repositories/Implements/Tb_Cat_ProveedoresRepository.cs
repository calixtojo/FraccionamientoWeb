using FraccionamientoWeb.BL.Models;
using FraccionamientoWeb.BL.Data;

namespace FraccionamientoWeb.BL.Repositories.Implements
{
    public class Tb_Cat_ProveedoresRepository : GenericRepository<Tb_Cat_Proveedores>
    {
        public Tb_Cat_ProveedoresRepository(FraccionamientoContext fraccionamientoContext):base(fraccionamientoContext)
        {

        }
    }
}
