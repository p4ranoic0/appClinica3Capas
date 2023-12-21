using Clinica_ADO;
using System;
using System.Data;

namespace Clinica_BL
{
    public class UbigeoBL
    {
        UbigeoADO objUbigeoADO = new UbigeoADO();

        public DataTable Ubigeo_Departamentos()
        {
            return objUbigeoADO.Ubigeo_Departamentos();
        }
        public DataTable Ubigeo_ProvinciasDepartamento(String strIdDepartamento)
        {
            return objUbigeoADO.Ubigeo_ProvinciasDepartamento(strIdDepartamento);
        }
        public DataTable Ubigeo_DistritosProvinciaDepartamento(String strIdDepartamento, String strIdProvincia)
        {
            return objUbigeoADO.Ubigeo_DistritosProvinciaDepartamento(strIdDepartamento, strIdProvincia);
        }

        public string BuscarUbigeo(string codUbigeo)
        {
            return objUbigeoADO.BuscarUbigeo(codUbigeo);
        }
    }
}
