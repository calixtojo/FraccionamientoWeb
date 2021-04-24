using FraccionamientoWeb.BL.Models;
using FraccionamientoWeb.BL.Repositories;

namespace FraccionamientoWeb.BL.Services.Implements
{
    public class Tb_Cat_MultasService : GenericService<Tb_Cat_Multas>
    {
        public Tb_Cat_MultasService(ITb_Cat_MultasRepository tb_Cat_MultasRepository):base(tb_Cat_MultasRepository)
        {

        }
    }
}
