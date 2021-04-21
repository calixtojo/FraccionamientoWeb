using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FraccionamientoWeb.BL.Models
{
    [Table("tb_cat_conceptos",Schema ="adminfrac")]
    public class Tb_Cat_Conceptos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Concepto { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
    }
}
