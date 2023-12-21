using Clinica_ADO;
using Clinica_BE;
using System;
using System.Data;

namespace Clinica_BL
{
    public class MedicoBL
    {
        MedicoADO objMedicoADO = new MedicoADO();
        public Boolean InsertarMedico(MedicoBE objMedicoBE)
        {
            return objMedicoADO.InsertarMedico(objMedicoBE);
        }
        public Boolean ActualizarMedico(MedicoBE objMedicoBE)
        {
            return objMedicoADO.ActualizarMedico(objMedicoBE);
        }
        public Boolean EliminarMedico(String strCod)
        {
            return objMedicoADO.EliminarMedico(strCod);
        }
        public MedicoBE ConsultarMedico(String strCod)
        {
            return objMedicoADO.ConsultarMedico(strCod);
        }
        public DataTable ListarMedico()
        {
            return objMedicoADO.ListarMedico();
        }

        public DataTable ListarEspecialidad()
        {
            return objMedicoADO.ListarEspecialidad();
        }

    }
}
