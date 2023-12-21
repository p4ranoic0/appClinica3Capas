using Clinica_ADO;
using Clinica_BE;
using System;
using System.Data;

namespace Clinica_BL
{
    public class AtencionBL
    {
        AtencionADO objAtencionADO = new AtencionADO();
        public Boolean InsertarAtencion(AtencionBE objAtencionBE)
        {
            return objAtencionADO.InsertarAtencion(objAtencionBE);
        }
        public Boolean ActualizarAtencion(AtencionBE objAtencionBE)
        {
            return objAtencionADO.ActualizarAtencion(objAtencionBE);
        }
        public Boolean EliminarAtencion(String strCod)
        {
            return objAtencionADO.EliminarAtencion(strCod);
        }
        public AtencionBE ConsultarAtencion(String strCod)
        {
            return objAtencionADO.ConsultarAtencion(strCod);
        }
        public DataTable ListarAtencion()
        {
            return objAtencionADO.ListarAtencion();
        }

        public DataTable ListarSucursal()
        {
            return objAtencionADO.ListarSucursal();
        }
        public string BuscarSucursal(String strCod)
        {
            return objAtencionADO.BuscarSucursal(strCod);
        }
    }
}
