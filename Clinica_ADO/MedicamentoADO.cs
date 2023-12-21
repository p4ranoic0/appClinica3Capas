using Clinica_BE;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Clinica_ADO
{
    public class MedicamentoADO
    {
        private ConexionADO MiConexion;
        SqlDataReader dtr;

        public MedicamentoADO() => MiConexion = new ConexionADO();


        public MedicamentoBE ConsultarMedicamento(string strCod)
        {
            MedicamentoBE objMedicamentoBE = new MedicamentoBE();
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarMedicamento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod_medi", strCod);
                try
                {
                    //ABRIMOS CONEXION Y EJECUTAMOS...
                    cnx.Open();
                    dtr = cmd.ExecuteReader();
                    //preguntamos si se devolvio el resultado
                    if (dtr.HasRows == true)
                    {
                        dtr.Read();
                        objMedicamentoBE.Cod_medi = dtr["cod_medi"].ToString();
                        objMedicamentoBE.Nom_medi = dtr["nom_medi"].ToString();
                        objMedicamentoBE.Comp_medi = dtr["comp_medi"].ToString();
                        objMedicamentoBE.Cod_lab = dtr["cod_lab"].ToString();
                        objMedicamentoBE.Mlgr_medi = dtr["mlgr_medi"].ToString();
                        objMedicamentoBE.Fec_reg1 = Convert.ToDateTime(dtr["Fec_reg"].ToString());
                        objMedicamentoBE.Usu_Registro1 = dtr["Usu_Registro"].ToString();
                        //objMedicamentoBE.Fec_Ult_Mod1 = Convert.ToDateTime(dtr["Fec_Ult_Mod"].ToString());
                        objMedicamentoBE.Usu_Ult_Mod1 = dtr["Usu_Ult_Mod"].ToString();
                        objMedicamentoBE.Est_medi1 = Convert.ToInt16(dtr["Est_medi"].ToString());

                    }
                    dtr.Close();
                    return objMedicamentoBE;
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



        public bool InsertarMedicamento(MedicamentoBE objMedicamentoBE)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarMedicamento";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@vnom_medi", objMedicamentoBE.Nom_medi);
                cmd.Parameters.AddWithValue("@vcomp_medi", objMedicamentoBE.Comp_medi);
                cmd.Parameters.AddWithValue("@vcod_lab", objMedicamentoBE.Cod_lab);
                cmd.Parameters.AddWithValue("@vmlgr_medi", objMedicamentoBE.Mlgr_medi);
                cmd.Parameters.AddWithValue("@vusu_registro", objMedicamentoBE.Usu_Registro1);
                cmd.Parameters.AddWithValue("@vest_medi", objMedicamentoBE.Est_medi1);

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


        public bool ActualizarMedicamento(MedicamentoBE objMedicamentoBE)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarMedicamento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod_medi", objMedicamentoBE.Cod_medi);
                cmd.Parameters.AddWithValue("@vnom_medi", objMedicamentoBE.Nom_medi);
                cmd.Parameters.AddWithValue("@vcomp_medi", objMedicamentoBE.Comp_medi);
                cmd.Parameters.AddWithValue("@vcod_lab", objMedicamentoBE.Cod_lab);
                cmd.Parameters.AddWithValue("@vmlgr_medi", objMedicamentoBE.Mlgr_medi);
                cmd.Parameters.AddWithValue("@vusu_registro", objMedicamentoBE.Usu_Registro1);
                cmd.Parameters.AddWithValue("@vest_medi", objMedicamentoBE.Est_medi1);

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
        public bool EliminarMedicamento(string strCod)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarMedicamento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Vcod_medi", strCod);
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

        public DataTable ListarLaboratorio()
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarLaboratorio";
                try
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@campo_orden", "nom_lab");
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Laboratorios");
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

        public DataTable ListarMedicamento()
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarMedicamento";
                try
                {
                    cmd.Parameters.Clear();
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Medicamentos");
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

        public string BuscarLaboratorio(string strCod)
        {
            using (SqlConnection cnx = MiConexion.GetSqlConnection())
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                string laboratorio = "";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarLaboratorio";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod_lab", strCod);
                try
                {
                    //ABRIMOS CONEXION Y EJECUTAMOS...
                    cnx.Open();
                    dtr = cmd.ExecuteReader();
                    //preguntamos si se devolvio el resultado
                    if (dtr.HasRows == true)
                    {
                        dtr.Read();
                        laboratorio = dtr["nom_lab"].ToString();

                    }
                    dtr.Close();
                    return laboratorio;
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
