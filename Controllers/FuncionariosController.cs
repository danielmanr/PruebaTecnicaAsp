using Microsoft.AspNetCore.Mvc;
using PruebaPro.Models;
using PruebaPro.DAO;

namespace PruebaPro.Controllers
{
    public class FuncionariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VistaFuncionarios()
        {

            try
            {
                Conexion cn = new Conexion();
                var funcionarios = cn.traerDatos();

                TempData["MSG"] = "Listado de Funcionarios";
                return View(funcionarios);

            }
            catch (Exception ex)
            {
                TempData["ERROR"] = ex.Message;
                return View();
            }

        }


        public IActionResult BuscarFuncionarios(string buscar)
        {
            try
            {
                string id = buscar;
                Conexion cn = new Conexion();
                var funcionarios = cn.buscarFuncionario(buscar);
                TempData["MSG"] = "Listado filtrado";
                return View("VistaFuncionarios", funcionarios);

            }
            catch (Exception ex)
            {
                TempData["ERROR"] = ex.Message;
                return View();
            }

        }
    }
}
