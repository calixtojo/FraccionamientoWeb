using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FraccionamientoWeb.BL.Models
{
    [Table("tb_cat_visitas",Schema ="adminfrac")]
    public class Tb_Cat_Visitas
    {   

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_tipo_visita { get; set; }

        public string Descripcion { get; set; }

        public bool Activo { get; set; }

    }
}
