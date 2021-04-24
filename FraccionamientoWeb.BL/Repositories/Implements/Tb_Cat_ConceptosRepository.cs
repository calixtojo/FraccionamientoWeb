using FraccionamientoWeb.BL.Data;
using FraccionamientoWeb.BL.Models;

namespace FraccionamientoWeb.BL.Repositories.Implements
{
    public class Tb_Cat_ConceptosRepository : GenericRepository<Tb_Cat_Conceptos>
    {
        public Tb_Cat_ConceptosRepository(FraccionamientoContext fraccionamientoContext):base(fraccionamientoContext)
        {

        }
    }
}
