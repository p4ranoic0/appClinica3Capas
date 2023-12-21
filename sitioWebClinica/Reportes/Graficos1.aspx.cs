using Clinica_BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Data;

namespace sitioWebClinica.Reportes
{
    public partial class Graficos1 : System.Web.UI.Page
    {
        AtencionBL atencionBL = new AtencionBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            // Obtener datos estadísticos
            DataTable dtAtenciones = atencionBL.ListarAtencion();

            // Convertir DataTable a List<DataRow>
            List<DataRow> listaAtenciones = dtAtenciones.AsEnumerable().ToList();

            // Calcular la cantidad de atenciones por número de sala
            var estadisticas = listaAtenciones
                .GroupBy(row => row.Field<string>("num_sala"))
                .Select(g => new
                {
                    NumSala = g.Key,
                    CantidadAtenciones = g.Count()
                })
                .OrderByDescending(stat => stat.CantidadAtenciones) // Ordenar de mayor a menor cantidad de atenciones
                .Take(6); // Tomar solo las 5 primeras salas

            // Convertir datos a formato JSON
            var jsonEstadisticas = Newtonsoft.Json.JsonConvert.SerializeObject(new
            {
                labels = estadisticas.Select(stat => stat.NumSala),
                data = estadisticas.Select(stat => stat.CantidadAtenciones)
            });

            // Pasar datos al frontend
            ScriptManager.RegisterStartupScript(this, this.GetType(), "CargarGrafico", $"CargarGrafico({jsonEstadisticas});", true);
        }
    }
}
