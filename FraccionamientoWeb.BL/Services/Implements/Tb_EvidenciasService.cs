using FraccionamientoWeb.BL.Models;
using FraccionamientoWeb.BL.Repositories;

namespace FraccionamientoWeb.BL.Services.Implements
{
    public class Tb_EvidenciasService: GenericService<Tb_Evidencias>
    {
        public Tb_EvidenciasService(ITb_EvidenciasRepository tb_EvidenciasRepository):base(tb_EvidenciasRepository)
        {

        }
    }
}
