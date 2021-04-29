using System;
using System.ComponentModel.DataAnnotations;

namespace FraccionamientoWeb.BL.DTOs
{
    public class Tb_Cat_Area_ComunDTO
    {
        [Required(ErrorMessage ="El campo es requerido")]
        public int Id_Area_Comun { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public Boolean Activo { get; set; }
    }
}
