using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FraccionamientoWeb.BL.Models
{
    [Table("tb_cat_tipo_pago",Schema ="adminfrac")]
    public class Tb_Cat_Tipo_Pago
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Tipo_Pago { get; set; }

        public string Descripcion { get; set; }

        public  int Activo { get; set; }
    }
}
