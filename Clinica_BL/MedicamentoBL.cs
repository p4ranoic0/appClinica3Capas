using Clinica_ADO;
using Clinica_BE;
using System;
using System.Data;

namespace Clinica_BL
{
    public class MedicamentoBL
    {
        MedicamentoADO objMedicamentoADO = new MedicamentoADO();
        public Boolean InsertarMedicamento(MedicamentoBE objMedicamentoBE)
        {
            return objMedicamentoADO.InsertarMedicamento(objMedicamentoBE);
        }
        public Boolean ActualizarMedicamento(MedicamentoBE objMedicamentoBE)
        {
            return objMedicamentoADO.ActualizarMedicamento(objMedicamentoBE);
        }
        public Boolean EliminarMedicamento(String strCod)
        {
            return objMedicamentoADO.EliminarMedicamento(strCod);
        }
        public MedicamentoBE ConsultarMedicamento(String strCod)
        {
            return objMedicamentoADO.ConsultarMedicamento(strCod);
        }
        public DataTable ListarMedicamento()
        {
            return objMedicamentoADO.ListarMedicamento();
        }

        public DataTable ListarLaboratorio()
        {
            return objMedicamentoADO.ListarLaboratorio();
        }

        public string BuscarLaboratorio(string strCod)
        {
            return objMedicamentoADO.BuscarLaboratorio(strCod);
        }
    }
}
