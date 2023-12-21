using Clinica_BE;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Clinica_ADO
{
    public class AtencionADO
    {
        private ConexionADO MiConexion;
        SqlDataReader dtr;

        public AtencionADO() => MiConexion = new ConexionADO();

        public bool ActualizarAtencion(AtencionBE objAtencionBE)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarAtencion";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@cod_ate", objAtencionBE.Cod_ate);
                cmd.Parameters.AddWithValue("@nuevo_cod_med", objAtencionBE.Cod_med);
                cmd.Parameters.AddWithValue("@nuevo_comen_ate", objAtencionBE.Comen_ate);
                cmd.Parameters.AddWithValue("@nuevo_est_ate", objAtencionBE.Est_ate);
                cmd.Parameters.AddWithValue("@nuevo_num_sala", objAtencionBE.Num_sala);
                cmd.Parameters.AddWithValue("@nuevo_Fec_Ult_Mod", objAtencionBE.Fec_Ult_Mod1);
                cmd.Parameters.AddWithValue("@nuevo_Usu_Ult_Mod", objAtencionBE.Usu_Ult_Mod1);

                cmd.Parameters.AddWithValue("@nuevo_cod_suc", objAtencionBE.Cod_suc);
                cmd.Parameters.AddWithValue("@nuevo_cod_pac", objAtencionBE.Cod_pac);

                try
                {
                    //Abrimos y ejecutamos...
                    cnx.Open();
                    cmd.ExecuteNonQuery();
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

        public AtencionBE ConsultarAtencion(string strCod)
        {
            AtencionBE objAtencionBE = new AtencionBE();

            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarAtencion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod_ate", strCod);
                try
                {
                    //ABRIMOS CONEXION Y EJECUTAMOS...
                    cnx.Open();
                    dtr = cmd.ExecuteReader();
                    //preguntamos si se devolvio el resultado
                    if (dtr.HasRows == true)
                    {
                        dtr.Read();
                        objAtencionBE.Cod_ate = dtr["cod_ate"].ToString();
                        objAtencionBE.Cod_med = dtr["cod_med"].ToString();
                        objAtencionBE.Comen_ate = dtr["comen_ate"].ToString();
                        objAtencionBE.Est_ate = dtr["est_ate"].ToString();
                        objAtencionBE.Num_sala = dtr["num_sala"].ToString();
                        objAtencionBE.Fec_reg1 = Convert.ToDateTime(dtr["Fec_reg"].ToString());
                        objAtencionBE.Usu_Registro1 = dtr["Usu_Registro"].ToString();
                        //objAtencionBE.Fec_Ult_Mod1 = Convert.ToDateTime(dtr["Fec_Ult_Mod"].ToString());
                        objAtencionBE.Usu_Ult_Mod1 = dtr["Usu_Ult_Mod"].ToString();
                        objAtencionBE.Cod_suc = dtr["cod_suc"].ToString();
                        objAtencionBE.Cod_pac = dtr["cod_pac"].ToString();

                    }
                    dtr.Close();
                    return objAtencionBE;
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

        public bool EliminarAtencion(string strCod)
        {
            throw new NotImplementedException();
        }

        public bool InsertarAtencion(AtencionBE objAtencionBE)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarAtencion";
                cmd.Parameters.Clear();

               
                cmd.Parameters.AddWithValue("@cod_med", objAtencionBE.Cod_med);
                cmd.Parameters.AddWithValue("@comen_ate", objAtencionBE.Comen_ate);
                cmd.Parameters.AddWithValue("@est_ate", objAtencionBE.Est_ate);
                cmd.Parameters.AddWithValue("@num_sala", objAtencionBE.Num_sala);
                cmd.Parameters.AddWithValue("@Fec_reg", objAtencionBE.Fec_reg1);
                cmd.Parameters.AddWithValue("@Usu_Registro", objAtencionBE.Usu_Registro1);

                cmd.Parameters.AddWithValue("@cod_suc", objAtencionBE.Cod_suc);
                cmd.Parameters.AddWithValue("@cod_pac", objAtencionBE.Cod_pac);

                try
                {
                    //Abrimos y ejecutamos...
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                    return false;
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

  

        public DataTable ListarAtencion()
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarAtencion";
                try
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@campo_orden", "cod_ate");
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Atenciones");
                    ada.Fill(dt);
                    return dt;
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

        public DataTable ListarSucursal()
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarSucursal";
                try
                {
                    cmd.Parameters.Clear();
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Sucursales");
                    ada.Fill(dt);
                    return dt;
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

        public string BuscarSucursal(string strCod)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())

            {
                string sucursal = "";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarSucursal";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod_suc", strCod);
                try
                {
                    //ABRIMOS CONEXION Y EJECUTAMOS...
                    cnx.Open();
                    dtr = cmd.ExecuteReader();
                    //preguntamos si se devolvio el resultado
                    if (dtr.HasRows == true)
                    {
                        dtr.Read();
                        sucursal = dtr["nom_suc"].ToString();
                    }
                    dtr.Close();
                    return sucursal;
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
