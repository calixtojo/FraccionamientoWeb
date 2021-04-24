using FraccionamientoWeb.BL.Models;
using FraccionamientoWeb.BL.Repositories;

namespace FraccionamientoWeb.BL.Services.Implements
{
    public class Tb_VisitasService: GenericService<Tb_Visitas>
    {
        public Tb_VisitasService(ITb_VisitasRepository tb_VisitasRepository):base(tb_VisitasRepository)
        {

        }
    }
}
