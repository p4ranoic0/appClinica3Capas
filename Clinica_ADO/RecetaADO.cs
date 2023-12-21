using Clinica_BE;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Clinica_ADO
{
    public class RecetaADO
    {
        private ConexionADO MiConexion;
        SqlDataReader dtr;

        public RecetaADO() => MiConexion = new ConexionADO();



        public RecetaBE ConsultarReceta(string strCod)
        {
            RecetaBE objRecetaBE = new RecetaBE();

            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarReceta";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod_rec", strCod);
                try
                {
                    //ABRIMOS CONEXION Y EJECUTAMOS...
                    cnx.Open();
                    dtr = cmd.ExecuteReader();
                    //preguntamos si se devolvio el resultado
                    if (dtr.HasRows == true)
                    {
                        dtr.Read();
                        objRecetaBE.Cod_rec = dtr["cod_rec"].ToString();
                        objRecetaBE.Fec_reg1 = Convert.ToDateTime(dtr["fech_nac_pac"].ToString());
                        objRecetaBE.Cod_ate = dtr["cod_ate"].ToString();
                        objRecetaBE.Usu_Registro1 = dtr["Usu_Registro"].ToString();

                        objRecetaBE.Estado1 = dtr["Estado"].ToString();

                    }
                    dtr.Close();
                    return objRecetaBE;
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
        public bool ActualizarReceta(RecetaBE objRecetaBE)
        {
            throw new NotImplementedException();
        }

        public bool EliminarReceta(string strCod)
        {
            throw new NotImplementedException();
        }

        public bool InsertarReceta(RecetaBE objRecetaBE, out string codigoReceta)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarReceta";
                cmd.Parameters.Clear();

                // Parámetro de salida para el código de receta
                SqlParameter codigoRecetaParam = new SqlParameter("@vcod_rec", SqlDbType.NChar, 4);
                codigoRecetaParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(codigoRecetaParam);

                cmd.Parameters.AddWithValue("@usu_reg", objRecetaBE.Usu_Registro1);
                cmd.Parameters.AddWithValue("@vcod_ate", objRecetaBE.Cod_ate);
                cmd.Parameters.AddWithValue("@est_rec", objRecetaBE.Est_rec1);
                //cmd.Parameters.AddWithValue("@cod_ubigeo", objRecetaBE.Cod_ubigeo);



                try
                {
                    //Abrimos y ejecutamos...
                    cnx.Open();
                    cmd.ExecuteNonQuery();

                    // Obtenemos el valor del código de receta generado
                    codigoReceta = codigoRecetaParam.Value.ToString();

                    return true;
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

        public DataTable ListarDetalleReceta(string strCod)
        {
            throw new NotImplementedException();
        }

        public DataTable ListarReceta()
        {
            throw new NotImplementedException();
        }
    }
}
