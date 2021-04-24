using System;
using MySql.Data.EntityFramework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using FraccionamientoWeb.BL.Models;



namespace FraccionamientoWeb.BL.Data
{
    public class FraccionamientoContext : DbContext
    {
        private static FraccionamientoContext fraccionamientoContext = null;

        public FraccionamientoContext() : base("FraccionamientoContext")
        {

        }

        public DbSet<Tb_Cat_Area_Comun> TB_Cat_Area_Comun { get; set; }
        public DbSet<Tb_Cat_Conceptos> TB_Cat_Conceptos { get; set; }
        public DbSet<Tb_Cat_Montos> TB_Cat_Montos { get; set; }
        public DbSet<Tb_Cat_Multas> TB_Cat_Multas { get; set; }
        public DbSet<Tb_Cat_Proveedores> TB_Cat_Proveedores { get; set; }
        public DbSet<Tb_Cat_Tipo_Pago> TB_Cat_Tipo_Pago { get; set; }
        public DbSet<Tb_Cat_Visitas> TB_Cat_Visitas{ get; set; }
        public DbSet<Tb_Cobros> TB_Cobros{ get; set; }
        public DbSet<Tb_Evidencias> TB_Evidencias{ get; set; }
        public DbSet<Tb_Multas> TB_Multas{ get; set; }
        public DbSet<Tb_Pagos> TB_Pagos{ get; set; }
        public DbSet<Tb_Reserva_Area_Comun> TB_Reserva_Area_Comun{ get; set; }
        public DbSet<Tb_Visitas> TB_Visitas{ get; set; }


        /// <summary>
        /// Se instancia para crear conexion a BD
        /// </summary>
        /// <returns></returns>
        public static FraccionamientoContext Create()
        {
            //if(fraccionamientoContext == null)
            //{
            //    fraccionamientoContext = new FraccionamientoContext();
            //}
            return new FraccionamientoContext();
        }






    }
}
