using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Clinica_ADO
{
    public class ConexionADO
    {

        public string GetCnx()
        {

            string strCnx =
                ConfigurationManager.ConnectionStrings["Medico"].ConnectionString;
            if (object.ReferenceEquals(strCnx, string.Empty))
            {
                // Puedes lanzar una excepción o manejar de otra manera
                throw new Exception("La cadena de conexión 'Medico' no está configurada correctamente.");
            }
            else
            {
                return strCnx;
            }
        }
        public SqlConnection GetSqlConnection()
        {
            string connectionString = GetCnx();
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

    }
}
