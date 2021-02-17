using Microsoft.AspNetCore.Mvc;

namespace Scisense.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Institucional()
        {
            return View();
        }
        public IActionResult Servicos()
        {
            return View();
        }
        public IActionResult Contato()
        {
            return View();
        }
        public IActionResult Legislacao()
        {
            return View();
        }
        public IActionResult Inbox()
        {
            return View();
        }
    }
}
