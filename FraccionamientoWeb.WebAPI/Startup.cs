using FraccionamientoWeb.BL.Data;
using Owin;

namespace FraccionamientoWeb.WebAPI
{
    public partial class Startup
    {
        /// <summary>
        /// Se comenta hasta crear la referencia
        /// </summary>
        /// <param name="app"></param>
        public void ConfigureAuth(IAppBuilder app)
        {
            app.CreatePerOwinContext(FraccionamientoContext.Create);

        }
    }
}
