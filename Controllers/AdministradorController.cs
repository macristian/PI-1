using Scisense.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace Scisense.Controllers
{
    public class AdministradorController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Administrador adm)
        {
            AdministradorRepository Adm = new AdministradorRepository();
            Administrador administrador = Adm.QueryLogin(adm);
            if (administrador != null)
            {
                ViewBag.MsgLogado = "Você está logado";
                HttpContext.Session.SetInt32("idAdm", administrador.IdAdm);
                HttpContext.Session.SetString("UserName", administrador.Login);
                return Redirect("Login");
            }
            else
            {
                ViewBag.MsgErro = "Falha de Autenticação. Entre em contato com o suporte técnico";
                return View();
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear(); //limpa toda a sessão
            return RedirectToAction("Login");
        }
    }
}