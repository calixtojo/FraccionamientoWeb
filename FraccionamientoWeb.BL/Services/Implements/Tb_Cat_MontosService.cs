using FraccionamientoWeb.BL.Models;
using FraccionamientoWeb.BL.Repositories;

namespace FraccionamientoWeb.BL.Services.Implements
{
    public class Tb_Cat_MontosService : GenericService<Tb_Cat_Montos>
    {
        public Tb_Cat_MontosService(ITb_Cat_MontosRepository tb_Cat_MontosRepository):base(tb_Cat_MontosRepository)
        {

        }
    }
}
