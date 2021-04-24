using FraccionamientoWeb.BL.Models;
using FraccionamientoWeb.BL.Repositories;

namespace FraccionamientoWeb.BL.Services.Implements
{
    public class Tb_PagosService:GenericService<Tb_Pagos>
    {
        public Tb_PagosService(ITb_PagosRepository tb_PagosRepository):base(tb_PagosRepository)
        {

        }
    }
}
