using Desarrollador.ComandosSql;
using Desarrollador.Models;
using Microsoft.AspNetCore.Mvc;

namespace Desarrollador.Controllers
{
    public class InformacionInscriocionPersonalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public List<ModalidadModel> Modalidad()
        {
            List<ModalidadModel> ConsultarEntidadPersonas = ComandoSql.ConsultarModalidad();
            return ConsultarEntidadPersonas;
        }

        public List<ModalidadModel> Sede()
        {
            List<ModalidadModel> ConsultarEntidadPersonas = ComandoSql.ConsultarSede();
            return ConsultarEntidadPersonas;
        }

        public List<ModalidadModel> Programa() 
        {
            List<ModalidadModel> ConsultarEntidadPersonas = ComandoSql.ConsultarPrograma();
            return ConsultarEntidadPersonas;
        }

        public List<PaisModel> Pais()
        { 
            List<PaisModel> ConsultarPais = ComandoSql.ConsultarPais();
            return ConsultarPais;
        }

        public List<DepartamentoModel> Departamentos(string CodigoPais) 
        {
            List<DepartamentoModel> ConsultarPais = ComandoSql.ConsultarDepartamentos(CodigoPais);
            return ConsultarPais;
        }

        public List<CiudadModel> Ciudades(string CodigoDepartamento)
        {
            List<CiudadModel> ConsultarPais = ComandoSql.ConsultarCiudades(CodigoDepartamento);
            return ConsultarPais;
        }

        public List<IdentificacionModel> Identificacion()
        {
            List<IdentificacionModel> ConsultarTipoIdent = ComandoSql.ConsultarTipoIdentificacion(); 
            return ConsultarTipoIdent; 
        }

        public List<GrupoSanguineoModel> GrupoSanguineo() 
        {
            List<GrupoSanguineoModel> ConsultarGrupoSanguineo = ComandoSql.ConsultarGrupoSanguineo();
            return ConsultarGrupoSanguineo;
        }

        public List<CiudadModel> CiudadExpedicion()
        {
            List<CiudadModel> ConsultarCiudad = ComandoSql.ConsultarCiudadExpedicion(); 
            return ConsultarCiudad; 
        }


        public string GuardarInfoInscripcion(string PrimerNombre, string SegundoNombre , string PrimerApellido, string SegundoApellido, string fechadenacimiento, string Pais, string Departamento, string Ciudad, string GrupoG, string TipoIdent, string identificationNumber, string fechadeExpedicion, string CiudadExpedicion, string sexo, string EstadoCivil)
        {
            string estado = ComandoSql.InsertarInformacionInscripcion(PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, fechadenacimiento, Pais, Departamento, Ciudad, GrupoG, TipoIdent, identificationNumber, fechadeExpedicion, CiudadExpedicion, sexo, EstadoCivil);
            return estado; 
        }


        public string GuardarInfoPersonal(string TipoEstudiante, string Modalidad, string Sede, string Programa, string Periodo, string CedulaAspirante)
        { 
            string estado = ComandoSql.GuardarInfoPersonal(TipoEstudiante, Modalidad, Sede, Programa, Periodo, CedulaAspirante);
            return estado;
        }
    }
}
