using System.Web.Mvc;

namespace Senai.Chamados.Web.Controllers
{
    public class ErrosController : Controller
    {
        public ActionResult NaoEncontrado()
        {
            return View();
        }
    }
}