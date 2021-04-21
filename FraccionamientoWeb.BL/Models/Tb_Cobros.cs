using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FraccionamientoWeb.BL.Models
{
    [Table("tb_cobros",Schema ="adminfrac")]
    public  class Tb_Cobros
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_cobro { get; set; }

        public int Id_monto { get; set; }

        public int Id_evidencia { get; set; }

        public int Id_residente { get; set; }

        public int Id_usuario { get; set; }

        public DateTime Fecha_Cobro { get; set; }

        public int Id_Cuenta { get; set; }

        public int Id_Multa { get; set; }

        public bool Status { get; set; }

    }

}
