using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FraccionamientoWeb.BL.Models
{
    [Table("tb_cat_proveedores",Schema ="adminfrac")]
    public class Tb_Cat_Proveedores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Proveedor { get; set; }
        public string Descripcion { get; set; }
        public int Telefono1 { get; set; }
        public int Telefono2 { get; set; }
        public string Correo_Electronico { get; set; }
        public string Direccion { get; set; }
        public string Rfc { get; set; }
        public int Id_Cat_Servicio { get; set; }
        public bool Activo { get; set; }

    }
}
