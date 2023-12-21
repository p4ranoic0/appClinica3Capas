
using Clinica_ADO;
using Clinica_BE;
using System;
using System.Data;

namespace Clinica_BL
{
    public class PacienteBL
    {
        PacienteADO objPacienteADO = new PacienteADO();
        public Boolean InsertarPaciente(PacienteBE objPacienteBE)
        {
            return objPacienteADO.InsertarPaciente(objPacienteBE);
        }
        public Boolean ActualizarPaciente(PacienteBE objPacienteBE)
        {
            return objPacienteADO.ActualizarPaciente(objPacienteBE);
        }
        public Boolean EliminarPaciente(String strCod)
        {
            return objPacienteADO.EliminarPaciente(strCod);
        }
        public PacienteBE ConsultarPaciente(String strCod)
        {
            return objPacienteADO.ConsultarPaciente(strCod);
        }
        public DataTable ListarPaciente()
        {
            return objPacienteADO.ListarPaciente();
        }

        public DataTable ListarSeguro()
        {
            return objPacienteADO.ListarSeguro();
        }

        public PacienteBE ConsultarSeguro(String strCod)
        {
            return objPacienteADO.ConsultarSeguro(strCod);
        }
    }
}
