using FraccionamientoWeb.BL.Models;
using FraccionamientoWeb.BL.Repositories;

namespace FraccionamientoWeb.BL.Services.Implements
{
    public class Tb_Reserva_Area_ComunService: GenericService<Tb_Reserva_Area_Comun>
    {
        public Tb_Reserva_Area_ComunService(ITb_Reserva_Area_ComunRepository tb_Reserva_Area_ComunRepository) : base(tb_Reserva_Area_ComunRepository)
        {

        }
    }
}
