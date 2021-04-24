using FraccionamientoWeb.BL.Repositories;
using FraccionamientoWeb.BL.Models;

namespace FraccionamientoWeb.BL.Services.Implements
{
    public class Tb_Cat_VisitasService: GenericService<Tb_Cat_Visitas>
    {
        public Tb_Cat_VisitasService(ITb_Cat_VisitasRepository tb_Cat_VisitasRepository):base(tb_Cat_VisitasRepository)
        {

        }
    }
}
