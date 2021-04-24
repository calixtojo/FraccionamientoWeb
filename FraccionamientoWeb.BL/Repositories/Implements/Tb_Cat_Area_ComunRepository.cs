using FraccionamientoWeb.BL.Data;
using FraccionamientoWeb.BL.Models;

namespace FraccionamientoWeb.BL.Repositories.Implements
{
    public class Tb_Cat_Area_ComunRepository : GenericRepository<Tb_Cat_Area_Comun>,ITb_Cat_Area_ComunRepository
    {
        public Tb_Cat_Area_ComunRepository(FraccionamientoContext fraccionamientoContext) : base(fraccionamientoContext)
        {

        }
    }
}
