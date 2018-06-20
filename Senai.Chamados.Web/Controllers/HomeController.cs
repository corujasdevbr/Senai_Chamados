using System.Web.Mvc;

namespace Senai.Chamados.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Mensagem = "Seja Bem Vindo";
            return View();
        }
    }
}