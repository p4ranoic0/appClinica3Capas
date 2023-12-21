using Clinica_BE;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Clinica_ADO
{
    public class MedicoADO
    {
        private ConexionADO MiConexion;
        SqlDataReader dtr;

        public MedicoADO() => MiConexion = new ConexionADO();

        public DataTable ListarMedico()
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarMedico";
                try
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@campo_orden", "nom_med");
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Medicos");
                    ada.Fill(dt);
                    // Combina el nombre y el apellido en una nueva columna
                    dt.Columns.Add("NombreCompleto", typeof(string), "nom_med + ' ' + ape_med");



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
        public MedicoBE ConsultarMedico(String strCodigo)
        {
            MedicoBE objMedicoBE = new MedicoBE();
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarMedico";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod_med", strCodigo);
                try
                {
                    //ABRIMOS CONEXION Y EJECUTAMOS...
                    cnx.Open();
                    dtr = cmd.ExecuteReader();
                    //preguntamos si se devolvio el resultado
                    if (dtr.HasRows == true)
                    {
                        dtr.Read();
                        objMedicoBE.Cod_med = dtr["cod_med"].ToString();
                        objMedicoBE.Cod_espec = dtr["cod_espec"].ToString();
                        objMedicoBE.Nom_med = dtr["nom_med"].ToString();
                        objMedicoBE.Ape_med = dtr["ape_med"].ToString();
                        objMedicoBE.Email = dtr["email"].ToString();
                        objMedicoBE.Telf = dtr["telf"].ToString();
                        objMedicoBE.Num_colegiatura = dtr["num_colegiatura"].ToString();
                        objMedicoBE.Cod_ubigeo = dtr["cod_ubigeo"].ToString();
                        objMedicoBE.Fech_nac_med = Convert.ToDateTime(dtr["fech_nac_med"].ToString());
                        objMedicoBE.Est_med1 = Convert.ToInt16(dtr["est_med"].ToString());
                        objMedicoBE.Dir_med = dtr["dir_med"].ToString();
                        objMedicoBE.Genero = dtr["genero"].ToString();

                    }
                    dtr.Close();
                    return objMedicoBE;
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

       

        public Boolean InsertarMedico(MedicoBE objmedico)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarMedico";
                cmd.Parameters.Clear();
                               
                cmd.Parameters.AddWithValue("@cod_espec", objmedico.Cod_espec);
                cmd.Parameters.AddWithValue("@nom_med", objmedico.Nom_med);
                cmd.Parameters.AddWithValue("@ape_med", objmedico.Ape_med);
                cmd.Parameters.AddWithValue("@dir_med", objmedico.Dir_med);
                cmd.Parameters.AddWithValue("@comen_est_pac", "");
                cmd.Parameters.AddWithValue("@email", objmedico.Email);
                cmd.Parameters.AddWithValue("@telf", objmedico.Telf);
                cmd.Parameters.AddWithValue("@genero", objmedico.Genero);
                cmd.Parameters.AddWithValue("@fech_nac_med", objmedico.Fech_nac_med);
                cmd.Parameters.AddWithValue("@num_colegiatura", objmedico.Num_colegiatura);
                cmd.Parameters.AddWithValue("@Fec_reg", objmedico.Fec_reg1);
                cmd.Parameters.AddWithValue("@Usu_Registro", objmedico.Usu_Registro1);
                cmd.Parameters.AddWithValue("@Fec_Ult_Mod", objmedico.Fec_Ult_Mod1);
                cmd.Parameters.AddWithValue("@Usu_Ult_Mod", objmedico.Usu_Ult_Mod1);
                cmd.Parameters.AddWithValue("@Est_med", objmedico.Est_med1);
                cmd.Parameters.AddWithValue("@cod_ubigeo", objmedico.Cod_ubigeo);

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
        public Boolean ActualizarMedico(MedicoBE objmedico)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarMedico";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod_med", objmedico.Cod_med);
                cmd.Parameters.AddWithValue("@nuevo_cod_espec", objmedico.Cod_espec);
                cmd.Parameters.AddWithValue("@nuevo_nom_med", objmedico.Nom_med);
                cmd.Parameters.AddWithValue("@nuevo_ape_med", objmedico.Ape_med);
                cmd.Parameters.AddWithValue("@nuevo_dir_med", objmedico.Dir_med);
                cmd.Parameters.AddWithValue("@nuevo_comen_est_pac", "");
                cmd.Parameters.AddWithValue("@nuevo_email", objmedico.Email);
                cmd.Parameters.AddWithValue("@nuevo_telf", objmedico.Telf);
                cmd.Parameters.AddWithValue("@nuevo_genero", objmedico.Genero);
                cmd.Parameters.AddWithValue("@nueva_fech_nac_med", objmedico.Fech_nac_med);
                cmd.Parameters.AddWithValue("@nuevo_num_colegiatura", objmedico.Num_colegiatura);

                cmd.Parameters.AddWithValue("@nuevo_Fec_Ult_Mod", objmedico.Fec_Ult_Mod1);
                cmd.Parameters.AddWithValue("@nuevo_Usu_Ult_Mod", objmedico.Usu_Ult_Mod1);
                cmd.Parameters.AddWithValue("@nuevo_Est_med", objmedico.Est_med1);
                cmd.Parameters.AddWithValue("@nuevo_cod_ubigeo", objmedico.Cod_ubigeo);

                try
                {//Abrimos y ejecutamos...
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    return true;

                }
                catch (SqlException x)
                {
                    throw new Exception(x.Message);
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

        public Boolean EliminarMedico(String strCodigo)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarMedico";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@comed", strCodigo);
                try
                {
                    //ABRIMOS Y EJECUTAMOS
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    return true;

                }
                catch (SqlException x)
                {
                    throw new Exception(x.Message);
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

        public DataTable ListarEspecialidad()
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarEspecialidad";
                try
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@campo_orden", "nom_espec");
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Especialidad");
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
    }
}
