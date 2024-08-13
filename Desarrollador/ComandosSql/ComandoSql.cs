using Desarrollador.CadenaConexion;
using Desarrollador.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace Desarrollador.ComandosSql
{
    public class ComandoSql
    {
        public static List<ModalidadModel> ConsultarModalidad()
        {
            List<ModalidadModel> ListModalidad = new List<ModalidadModel>();

            try
            {

                using (SqlConnection oConexion = new SqlConnection(CadenaC.rutaConexion))
                {
                    string sql = "select Nombre,Codigo from Modalidad";

                    using (SqlCommand oConexion1 = new SqlCommand(sql, oConexion))
                    {
                        oConexion.Open();
                        using (SqlDataReader reader = oConexion1.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModalidadModel DataModalidad = new ModalidadModel();
                                DataModalidad.Nombre = reader.GetString(0);
                                DataModalidad.Codigo = reader.GetString(1);
                                ListModalidad.Add(DataModalidad);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                string error = ex.Message;
            } 

            return ListModalidad;
        }


        public static List<ModalidadModel> ConsultarSede() 
        {
            List<ModalidadModel> ListModalidad = new List<ModalidadModel>();

            try
            {

                using (SqlConnection oConexion = new SqlConnection(CadenaC.rutaConexion))
                {
                    string sql = "select Nombre,Codigo from Sede";

                    using (SqlCommand oConexion1 = new SqlCommand(sql, oConexion))
                    {
                        oConexion.Open();
                        using (SqlDataReader reader = oConexion1.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModalidadModel DataModalidad = new ModalidadModel();
                                DataModalidad.Nombre = reader.GetString(0);
                                DataModalidad.Codigo = reader.GetString(1);
                                ListModalidad.Add(DataModalidad);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

            return ListModalidad;
        }



        public static List<ModalidadModel> ConsultarPrograma()
        {
            List<ModalidadModel> ListModalidad = new List<ModalidadModel>();

            try
            {

                using (SqlConnection oConexion = new SqlConnection(CadenaC.rutaConexion))
                {
                    string sql = "select Nombre,Codigo from Programa";

                    using (SqlCommand oConexion1 = new SqlCommand(sql, oConexion))
                    {
                        oConexion.Open();
                        using (SqlDataReader reader = oConexion1.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ModalidadModel DataModalidad = new ModalidadModel();
                                DataModalidad.Nombre = reader.GetString(0);
                                DataModalidad.Codigo = reader.GetString(1);
                                ListModalidad.Add(DataModalidad);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

            return ListModalidad;
        }


        public static List<PaisModel> ConsultarPais()
        {
            List<PaisModel> ListPaisModel = new List<PaisModel>();

            try
            {

                using (SqlConnection oConexion = new SqlConnection(CadenaC.rutaConexion))
                {
                    string sql = "select Nombre,Codigo from Pais";

                    using (SqlCommand oConexion1 = new SqlCommand(sql, oConexion))
                    {
                        oConexion.Open();
                        using (SqlDataReader reader = oConexion1.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PaisModel PaisModel = new PaisModel();
                                PaisModel.Nombre = reader.GetString(0);
                                PaisModel.Codigo = reader.GetString(1);
                                ListPaisModel.Add(PaisModel);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

            return ListPaisModel; 
        }

        public static List<DepartamentoModel> ConsultarDepartamentos(string CodigoPais)
        {
            CodigoPais = "'" + CodigoPais + "'";
            List<DepartamentoModel> ListDep = new List<DepartamentoModel>(); 

            try
            {

                using (SqlConnection oConexion = new SqlConnection(CadenaC.rutaConexion))
                {
                    string sql = "select Nombre,Codigo from Departamento where FK_CodigoPais = " + CodigoPais;

                    using (SqlCommand oConexion1 = new SqlCommand(sql, oConexion))
                    {
                        oConexion.Open();
                        using (SqlDataReader reader = oConexion1.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DepartamentoModel DepartamentoModel = new DepartamentoModel();
                                DepartamentoModel.Nombre = reader.GetString(0);
                                DepartamentoModel.Codigo = reader.GetString(1);
                                ListDep.Add(DepartamentoModel);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

            return ListDep;
        }

        public static List<CiudadModel> ConsultarCiudades(string CodigoDepartamento)
        {
            CodigoDepartamento = "'" + CodigoDepartamento + "'";
            List<CiudadModel> ListCiudad = new List<CiudadModel>();

            try
            {

                using (SqlConnection oConexion = new SqlConnection(CadenaC.rutaConexion))
                {
                    string sql = "select Nombre,Codigo from Ciudad where FK_CodigoDepartamento = " + CodigoDepartamento;

                    using (SqlCommand oConexion1 = new SqlCommand(sql, oConexion))
                    {
                        oConexion.Open();
                        using (SqlDataReader reader = oConexion1.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CiudadModel CiudadModel = new CiudadModel();
                                CiudadModel.Nombre = reader.GetString(0);
                                CiudadModel.Codigo = reader.GetString(1);
                                ListCiudad.Add(CiudadModel);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

            return ListCiudad;
        }

        public static List<IdentificacionModel> ConsultarTipoIdentificacion()
        {
            List<IdentificacionModel> ListTipoIdentificacionModel = new List<IdentificacionModel>();

            try
            { 

                using (SqlConnection oConexion = new SqlConnection(CadenaC.rutaConexion))
                {
                    string sql = "select Nombre,Codigo from TipoIdentificacion";

                    using (SqlCommand oConexion1 = new SqlCommand(sql, oConexion))
                    {
                        oConexion.Open();
                        using (SqlDataReader reader = oConexion1.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IdentificacionModel IdentificacionModel = new IdentificacionModel();
                                IdentificacionModel.Nombre = reader.GetString(0);
                                IdentificacionModel.Codigo = reader.GetString(1);
                                ListTipoIdentificacionModel.Add(IdentificacionModel);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

            return ListTipoIdentificacionModel;
        }

        public static List<GrupoSanguineoModel> ConsultarGrupoSanguineo()
        {
            List<GrupoSanguineoModel> ListGrupoSanguineoModel = new List<GrupoSanguineoModel>(); 

            try
            {

                using (SqlConnection oConexion = new SqlConnection(CadenaC.rutaConexion))
                {
                    string sql = "select Nombre,Codigo from GrupoSanguineo";

                    using (SqlCommand oConexion1 = new SqlCommand(sql, oConexion))
                    {
                        oConexion.Open();
                        using (SqlDataReader reader = oConexion1.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                GrupoSanguineoModel GrupoSanguineoModel = new GrupoSanguineoModel();
                                GrupoSanguineoModel.Nombre = reader.GetString(0);
                                GrupoSanguineoModel.Codigo = reader.GetString(1);
                                ListGrupoSanguineoModel.Add(GrupoSanguineoModel);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

            return ListGrupoSanguineoModel;
        }

        public static List<CiudadModel> ConsultarCiudadExpedicion()
        {
            List<CiudadModel> ListCiudad = new List<CiudadModel>();

            try
            {

                using (SqlConnection oConexion = new SqlConnection(CadenaC.rutaConexion))
                {
                    string sql = "select Nombre,Codigo from Ciudad";

                    using (SqlCommand oConexion1 = new SqlCommand(sql, oConexion))
                    {
                        oConexion.Open();
                        using (SqlDataReader reader = oConexion1.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CiudadModel CiudadModel = new CiudadModel();
                                CiudadModel.Nombre = reader.GetString(0);
                                CiudadModel.Codigo = reader.GetString(1);
                                ListCiudad.Add(CiudadModel);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

            return ListCiudad;
        }


        public static string InsertarInformacionInscripcion(string PrimerNombre, string SegundoNombre, string PrimerApellido, string SegundoApellido, string fechadenacimiento, string Pais, string Departamento, string Ciudad, string GrupoG, string TipoIdent, string identificationNumber, string fechadeExpedicion, string CiudadExpedicion, string sexo, string EstadoCivil)
        {
            string result = "";
            int idEntidadUsuario = 0;

            DateTime fecha_denacimiento = Convert.ToDateTime(fechadenacimiento);
            fechadenacimiento = fecha_denacimiento.ToString("yyyyMMdd HH:mm:ss");

            DateTime fecha_Expedicion = Convert.ToDateTime(fechadeExpedicion);
            fechadeExpedicion = fecha_Expedicion.ToString("yyyyMMdd HH:mm:ss");

            try
            {

                idEntidadUsuario = ConsultarCedulaAspirante(identificationNumber);

                if (idEntidadUsuario == 0)
                {

                    using (SqlConnection oConexion = new SqlConnection(CadenaC.rutaConexion))
                    {
                        SqlCommand cmd = new SqlCommand("Insert_InformacionInscripcion", oConexion);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PrimerNombre", PrimerNombre);
                        cmd.Parameters.AddWithValue("@SegundoNombre", SegundoNombre);
                        cmd.Parameters.AddWithValue("@PrimerApellido", PrimerApellido);
                        cmd.Parameters.AddWithValue("@SegundoApellido", SegundoApellido);
                        cmd.Parameters.AddWithValue("@fechadenacimiento", fechadenacimiento);
                        cmd.Parameters.AddWithValue("@Pais", Pais);
                        cmd.Parameters.AddWithValue("@Departamento", Departamento);
                        cmd.Parameters.AddWithValue("@Ciudad", Ciudad);
                        cmd.Parameters.AddWithValue("@GrupoG", GrupoG);
                        cmd.Parameters.AddWithValue("@TipoIdent", TipoIdent);
                        cmd.Parameters.AddWithValue("@identificationNumber", identificationNumber);
                        cmd.Parameters.AddWithValue("@fechadeExpedicion", fechadeExpedicion);
                        cmd.Parameters.AddWithValue("@CiudadExpedicion", CiudadExpedicion);
                        cmd.Parameters.AddWithValue("@sexo", sexo);
                        cmd.Parameters.AddWithValue("@EstadoCivil", EstadoCivil);
                        try
                        {
                            oConexion.Open();
                            cmd.ExecuteNonQuery();
                            result = "Ok";
                        }
                        catch (Exception ex)
                        {
                            result = "Error";
                        }
                    }
                }
                else {
                    result = "Cedula Error";
                }

                
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

            return result;
        }


        public static string GuardarInfoPersonal(string TipoEstudiante, string Modalidad, string Sede, string Programa, string Periodo, string CedulaAspirante)
        {
            int idEntidadUsuario = 0;

            string result = "";

            try
            {

                idEntidadUsuario = ConsultarCedulaAspirante(CedulaAspirante);

                if (idEntidadUsuario != 0)
                {

                    using (SqlConnection oConexion = new SqlConnection(CadenaC.rutaConexion))
                    {
                        SqlCommand cmd = new SqlCommand("Insert_InformacionPersonal", oConexion);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TipoEstudiante", TipoEstudiante);
                        cmd.Parameters.AddWithValue("@Modalidad", Modalidad);
                        cmd.Parameters.AddWithValue("@Sede", Sede);
                        cmd.Parameters.AddWithValue("@Programa", Programa);
                        cmd.Parameters.AddWithValue("@Periodo", Periodo);
                        cmd.Parameters.AddWithValue("@CedulaAspirante", CedulaAspirante);
                        try
                        {
                            oConexion.Open();
                            cmd.ExecuteNonQuery();
                            result = "Ok";
                        }
                        catch (Exception ex)
                        {
                            result = "Error";
                        }
                    }
                }
                else {
                    result = "Cedula no inscrita";
                }
                
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

            return result;
        }

        public static int ConsultarCedulaAspirante(string Identificador) 

        {
            int idEntidadUsuario = 0;
            try
            {
                using (SqlConnection oConexion2 = new SqlConnection(CadenaC.rutaConexion))
                {
                    string sql = "SELECT idInformacionInscripcion from InformacionInscripcion where NumeroIdent =" + "'" + Identificador + "'";

                    using (SqlCommand oConexion3 = new SqlCommand(sql, oConexion2))
                    {
                        oConexion2.Open();
                        using (SqlDataReader reader = oConexion3.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                idEntidadUsuario = reader.GetInt32(0);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return idEntidadUsuario;
        }


        public static List<EstudiantesInscritos> CargarInfoEstudiantes()
        {
            List<EstudiantesInscritos> estudiantesInscritos = new List<EstudiantesInscritos>();

            try
            {

                using (SqlConnection oConexion = new SqlConnection(CadenaC.rutaConexion))
                {
                    string sql = "select IPE.TipoEstudiante Estado, sd.Nombre Sede, pr.Nombre ProgramaAcademico, IPE.CodPeriodo PeriodoAcademico , TI.Nombre TipoDocumento,InI.NumeroIdent NumeroDocumento, InI.PrimerNombre + SPACE(1) + InI.SegundoNombre Nombres, InI.PrimerApellido + SPACE(1) +  InI.SegundoApellido Apellidos  from InformacionInscripcion InI join InformacionPersonal IPE ON InI.NumeroIdent = IPE.FK_NumeroIdentificaion_InformacionInscripcion join Sede sd on IPE.CodSede = sd.Codigo join Programa pr on IPE.CodPrograma = pr.Codigo join TipoIdentificacion TI on InI.TipoIdentificacion = TI.Codigo";

                    using (SqlCommand oConexion1 = new SqlCommand(sql, oConexion))
                    {
                        oConexion.Open();
                        using (SqlDataReader reader = oConexion1.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                EstudiantesInscritos EstudiantesInscritosModel = new EstudiantesInscritos();
                                EstudiantesInscritosModel.Estado = reader.GetString(0);
                                EstudiantesInscritosModel.Sede = reader.GetString(1);
                                EstudiantesInscritosModel.ProgramaAcademico = reader.GetString(2);
                                EstudiantesInscritosModel.PeriodoAcademico = reader.GetString(3);
                                EstudiantesInscritosModel.TipoDocumento = reader.GetString(4);
                                EstudiantesInscritosModel.NumeroDocumento = reader.GetString(5);
                                EstudiantesInscritosModel.Nombres = reader.GetString(6);
                                EstudiantesInscritosModel.Apellidos = reader.GetString(7);
                                estudiantesInscritos.Add(EstudiantesInscritosModel);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

            return estudiantesInscritos;
        }

    }
}
