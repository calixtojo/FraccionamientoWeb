using FraccionamientoWeb.BL.Models;
using FraccionamientoWeb.BL.Data;
using FraccionamientoWeb.BL.Repositories;

namespace FraccionamientoWeb.BL.Services.Implements
{
    public class Tb_Cat_ProveedoresService : GenericService<Tb_Cat_Proveedores>
    {
        public Tb_Cat_ProveedoresService(ITb_Cat_ProveedoresRepository tb_Cat_ProveedoresRepository):base(tb_Cat_ProveedoresRepository)
        {

        }
    }
}
