using FraccionamientoWeb.BL.Repositories;
using FraccionamientoWeb.BL.Models;

namespace FraccionamientoWeb.BL.Services.Implements
{
    public class Tb_Cat_Tipo_PagoService: GenericService<Tb_Cat_Tipo_Pago>
    {
        public Tb_Cat_Tipo_PagoService(ITb_Cat_Tipo_PagoRepository tb_Cat_Tipo_PagoRepository):base(tb_Cat_Tipo_PagoRepository)
        {

        }
    }
}
