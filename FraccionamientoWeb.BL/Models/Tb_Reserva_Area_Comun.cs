using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FraccionamientoWeb.BL.Models
{
    [Table("tb_reserva_area_comun",Schema ="adminfrac")]
    public class Tb_Reserva_Area_Comun
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Reserva { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Residente { get; set; }
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Area_Comun { get; set; }

        public DateTime Fecha_Reserva { get; set; }

        [Key]
        public DateTime Fecha_Evento { get; set; }
    }
}
