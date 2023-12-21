using System;
using System.Web.UI;

namespace sitioWebClinica
{
    public partial class PageMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void MostrarToast(string titulo, string tipo, string mensaje)
        {
            // Eliminar espacios en blanco y saltos de línea del mensaje
            mensaje = mensaje.Replace("\r", "").Replace("\n", "").Replace("'", "").Trim();

            ScriptManager.RegisterStartupScript(this, this.GetType(), "MostrarToast", $"mostrarToast('{titulo}', '{tipo}', '{mensaje}');", true);
        }
    }
}
