using Desarrollador.ComandosSql;
using Desarrollador.Models;
using Microsoft.AspNetCore.Mvc;

namespace Desarrollador.Controllers
{
    public class AspirantesInscritosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<EstudiantesInscritos> CargarInfoEstudiantes()
        {
            List<EstudiantesInscritos> ConsultarPais = ComandoSql.CargarInfoEstudiantes();
            return ConsultarPais;
        }

    }
}
