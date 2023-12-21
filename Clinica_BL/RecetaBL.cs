using Clinica_ADO;
using Clinica_BE;
using System;
using System.Data;

namespace Clinica_BL
{
    public class RecetaBL
    {
        RecetaADO objRecetaADO = new RecetaADO();
        public Boolean InsertarReceta(RecetaBE objRecetaBE)
        {
            return objRecetaADO.InsertarReceta(objRecetaBE, out string codigoReceta);
        }
        public Boolean ActualizarReceta(RecetaBE objRecetaBE)
        {
            return objRecetaADO.ActualizarReceta(objRecetaBE);
        }
        public Boolean EliminarReceta(String strCod)
        {
            return objRecetaADO.EliminarReceta(strCod);
        }
        public RecetaBE ConsultarReceta(String strCod)
        {
            return objRecetaADO.ConsultarReceta(strCod);
        }
        public DataTable ListarReceta()
        {
            return objRecetaADO.ListarReceta();
        }

        public DataTable ListarDetalleReceta(String strCod)
        {
            return objRecetaADO.ListarDetalleReceta(strCod);
        }
    }
}
