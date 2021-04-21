using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FraccionamientoWeb.BL.Models
{
    [Table("tb_visitas",Schema ="adminfrac")]
    public class Tb_Visitas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Visita { get; set; }
        public int Id_Residente { get; set; }

        public int Id_Tipo_Visita { get; set; }
        public DateTime Hora_Visita { get; set; }

        public DateTime Fecha_Visita { get; set; }

    }
}
