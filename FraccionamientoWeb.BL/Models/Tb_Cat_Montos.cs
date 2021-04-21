using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FraccionamientoWeb.BL.Models
{
    [Table("tb_cat_montos",Schema ="adminfrac")]
   public class Tb_Cat_Montos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Cat_Multa { get; set; }

        public string Descripcion { get; set; }

        public bool Activo { get; set; }

    }
}
