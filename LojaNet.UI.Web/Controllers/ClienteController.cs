using Microsoft.AspNetCore.Mvc;
using System.Web;
using LojaNet.Models;


namespace LojaNet.UI.Web.Controllers
{
    public class ClienteController : Controller
    {

        public ActionResult Incluir()
        {
            var cli = new Cliente();

               return View(cli);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
