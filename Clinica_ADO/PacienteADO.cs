using Clinica_BE;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Clinica_ADO
{
    public class PacienteADO
    {
        private ConexionADO MiConexion;
        SqlDataReader dtr;

        public PacienteADO() => MiConexion = new ConexionADO();

        public PacienteBE ConsultarPaciente(string strCod)
        {
            PacienteBE objPacienteBE = new PacienteBE();

            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarPaciente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod_pac", strCod);
                try
                {
                    //ABRIMOS CONEXION Y EJECUTAMOS...
                    cnx.Open();
                    dtr = cmd.ExecuteReader();
                    //preguntamos si se devolvio el resultado
                    if (dtr.HasRows == true)
                    {
                        dtr.Read();
                        objPacienteBE.Cod_pac = dtr["cod_pac"].ToString();
                        objPacienteBE.Nom_pac = dtr["nom_pac"].ToString();
                        objPacienteBE.Ape_pac = dtr["ape_pac"].ToString();
                        objPacienteBE.Genero = dtr["genero"].ToString();
                        objPacienteBE.Telf = dtr["telf"].ToString();
                        objPacienteBE.Comen_pac = dtr["comen_pac"].ToString();
                        objPacienteBE.Dir_pac = dtr["dir_pac"].ToString();
                        objPacienteBE.Email = dtr["email"].ToString();
                        objPacienteBE.Fech_nac_pac = Convert.ToDateTime(dtr["fech_nac_pac"].ToString());
                        objPacienteBE.Sangre = dtr["sangre"].ToString();
                        objPacienteBE.Cod_seg = dtr["cod_seg"].ToString();
                        objPacienteBE.Est_pac = dtr["est_pac"].ToString();
                        objPacienteBE.Cod_ubigeo = dtr["cod_ubigeo"].ToString();
                        objPacienteBE.Dni = dtr["dni"].ToString();

                    }
                    dtr.Close();
                    return objPacienteBE;
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

        public bool InsertarPaciente(PacienteBE objPacienteBE)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarPaciente";
                cmd.Parameters.Clear();

                                
                cmd.Parameters.AddWithValue("@nom_pac", objPacienteBE.Nom_pac);
                cmd.Parameters.AddWithValue("@ape_pac", objPacienteBE.Ape_pac);
                cmd.Parameters.AddWithValue("@genero", objPacienteBE.Genero);
                cmd.Parameters.Add("@foto", SqlDbType.Image).Value = DBNull.Value;
                cmd.Parameters.AddWithValue("@telf", objPacienteBE.Telf);
                cmd.Parameters.AddWithValue("@comen_pac", "");
                cmd.Parameters.AddWithValue("@dir_pac", objPacienteBE.Dir_pac);
                cmd.Parameters.AddWithValue("@email", objPacienteBE.Email);
                cmd.Parameters.AddWithValue("@fech_nac_pac", objPacienteBE.Fech_nac_pac);
                cmd.Parameters.AddWithValue("@sangre", objPacienteBE.Sangre);
                cmd.Parameters.AddWithValue("@cod_seg", objPacienteBE.Cod_seg);
                cmd.Parameters.AddWithValue("@Usu_Registro", objPacienteBE.Usu_Registro1);
                cmd.Parameters.AddWithValue("@Fec_Ult_Mod", objPacienteBE.Fec_Ult_Mod1);
                cmd.Parameters.AddWithValue("@Usu_Ult_Mod", objPacienteBE.Usu_Ult_Mod1);
                cmd.Parameters.AddWithValue("@Est_pac", objPacienteBE.Est_pac);
                cmd.Parameters.AddWithValue("@cod_ubigeo", objPacienteBE.Cod_ubigeo);
                cmd.Parameters.AddWithValue("@dni", objPacienteBE.Dni);

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

        

        public bool ActualizarPaciente(PacienteBE objPacienteBE)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarPaciente";
                cmd.Parameters.Clear();


                cmd.Parameters.AddWithValue("@cod_pac", objPacienteBE.Cod_pac);
                cmd.Parameters.AddWithValue("@nuevo_nom_pac", objPacienteBE.Nom_pac);
                cmd.Parameters.AddWithValue("@nuevo_ape_pac", objPacienteBE.Ape_pac);
                cmd.Parameters.AddWithValue("@nuevo_genero", objPacienteBE.Genero);
                cmd.Parameters.Add("@nueva_foto", SqlDbType.Image).Value = DBNull.Value;
                cmd.Parameters.AddWithValue("@nuevo_telf", objPacienteBE.Telf);
                cmd.Parameters.AddWithValue("@nuevo_comen_pac", "");
                cmd.Parameters.AddWithValue("@nuevo_dir_pac", objPacienteBE.Dir_pac);
                cmd.Parameters.AddWithValue("@nuevo_email", objPacienteBE.Email);
                cmd.Parameters.AddWithValue("@nueva_fech_nac_pac", objPacienteBE.Fech_nac_pac);
                cmd.Parameters.AddWithValue("@nuevo_sangre", objPacienteBE.Sangre);
                cmd.Parameters.AddWithValue("@nuevo_cod_seg", objPacienteBE.Cod_seg);
                cmd.Parameters.AddWithValue("@nuevo_Usu_Registro", objPacienteBE.Usu_Registro1);
                cmd.Parameters.AddWithValue("@nuevo_Fec_Ult_Mod", objPacienteBE.Fec_Ult_Mod1);
                cmd.Parameters.AddWithValue("@nuevo_Usu_Ult_Mod", objPacienteBE.Usu_Ult_Mod1);
                cmd.Parameters.AddWithValue("@nuevo_Est_pac", objPacienteBE.Est_pac);
                cmd.Parameters.AddWithValue("@nuevo_cod_ubigeo", objPacienteBE.Cod_ubigeo);
                cmd.Parameters.AddWithValue("@nuevo_dni", objPacienteBE.Dni);


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
        public bool EliminarPaciente(string strCod)
        {
            throw new NotImplementedException();
        }

        public DataTable ListarPaciente()
        {

            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarPaciente";
                try
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@campo_orden", "nom_pac");
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Pacientes");
                    ada.Fill(dt);
                    // Combina el nombre y el apellido en una nueva columna
                    dt.Columns.Add("NombreCompleto", typeof(string), "nom_pac + ' ' + ape_pac");

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

        public DataTable ListarSeguro()
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarSeguro";
                try
                {
                    cmd.Parameters.Clear();
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Seguros");
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

        public PacienteBE ConsultarSeguro(string strCod)
        {
            PacienteBE objPacienteBE = new PacienteBE();

            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarSeguro";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcodseg", strCod);
                try
                {
                    //ABRIMOS CONEXION Y EJECUTAMOS...
                    cnx.Open();
                    dtr = cmd.ExecuteReader();
                    //preguntamos si se devolvio el resultado
                    if (dtr.HasRows == true)
                    {
                        dtr.Read();
                        objPacienteBE.Nom_sug = dtr["nom_sug"].ToString();

                    }
                    dtr.Close();
                    return objPacienteBE;
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
