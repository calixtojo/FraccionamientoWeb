using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FraccionamientoWeb.BL.Models
{
    [Table("tb_cat_area_comun")]
    public class Tb_Cat_Area_Comun
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Area_Comun { get; set; }
        public string Descripcion { get; set; }
        public Boolean Activo { get; set; }
    }
}
