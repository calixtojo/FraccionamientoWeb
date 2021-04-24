using FraccionamientoWeb.BL.Models;
using FraccionamientoWeb.BL.Repositories;

namespace FraccionamientoWeb.BL.Services.Implements
{
    public class Tb_MultasService: GenericService<Tb_Multas>
    {
        public Tb_MultasService(ITb_MultasRepository tb_MultasRepository):base(tb_MultasRepository)
        {

        }
    }
}
