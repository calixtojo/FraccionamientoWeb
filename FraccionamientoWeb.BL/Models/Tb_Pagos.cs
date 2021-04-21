using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FraccionamientoWeb.BL.Models
{
    [Table("tb_pagos",Schema ="adminfrac")]
    public class Tb_Pagos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Pagos { get; set; }
        public int Id_Residente { get; set; }
        public int Id_Tipo_Pago { get; set; }
        public int Id_Proveedor { get; set; }
        public int Id_Cuenta { get; set; }
        public int Id_Concepto { get; set; }
        public DateTime Fecha_Pago { get; set; }

        public float Monto { get; set; }

    }
}
