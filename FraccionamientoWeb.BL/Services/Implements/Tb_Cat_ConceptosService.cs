using FraccionamientoWeb.BL.Models;
using FraccionamientoWeb.BL.Repositories;


namespace FraccionamientoWeb.BL.Services.Implements
{
    public class Tb_Cat_ConceptosService:GenericService<Tb_Cat_Conceptos>
    {
        public Tb_Cat_ConceptosService(ITb_Cat_ConceptosRepository tb_Cat_ConceptosRepository) : base(tb_Cat_ConceptosRepository)
        {

        }
    }
}
