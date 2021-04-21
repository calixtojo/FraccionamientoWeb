using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FraccionamientoWeb.BL.Models
{
    [Table("tb_evidencias",Schema ="adminfrac")]
    public class Tb_Evidencias
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Evidencia { get; set; }
        public Byte Imagen { get; set; }
    }
}
