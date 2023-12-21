using System;
using System.Data;
using System.Data.SqlClient;

namespace Clinica_ADO
{
    public class UbigeoADO
    {
        private ConexionADO MiConexion;
        SqlDataReader dtr;

        public UbigeoADO()
        {
            MiConexion = new ConexionADO();
        }

        public DataTable Ubigeo_Departamentos()
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())

            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Ubigeo_Departamentos";
                try
                {
                    cmd.Parameters.Clear();
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("DepartamentoS");
                    ada.Fill(dt);
                    return dt;
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public DataTable Ubigeo_ProvinciasDepartamento(String strIdDepartamento)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Ubigeo_ProvinciasDepartamento";

                try
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@IdDepartamento", strIdDepartamento);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Provincias");
                    ada.Fill(dt);
                    return dt;
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public DataTable Ubigeo_DistritosProvinciaDepartamento(String strIdDepartamento, String strIdProvincia)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Ubigeo_DistritosProvinciaDepartamento";
                try
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@IdDepartamento", strIdDepartamento);
                    cmd.Parameters.AddWithValue("@IdProvincia", strIdProvincia);
                    DataTable dt = new DataTable("Distritos");
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(dt);
                    return dt;
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public string BuscarUbigeo(string codUbigeo)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())

            {
                string ubigeo = "";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_BuscarUbigeo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcodubigeo", codUbigeo);
                try
                {
                    //ABRIMOS CONEXION Y EJECUTAMOS...
                    cnx.Open();
                    dtr = cmd.ExecuteReader();
                    //preguntamos si se devolvio el resultado
                    if (dtr.HasRows == true)
                    {
                        dtr.Read();
                        ubigeo = dtr["Ubigeo"].ToString();
                    }
                    dtr.Close();
                    return ubigeo;
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    if (cnx.State == ConnectionState.Open)
                    {
                        cnx.Close();
                    }

                }
            }
        }
    }
}
