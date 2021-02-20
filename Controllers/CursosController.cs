using System.Collections.Generic;
using Scisense.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace Scisense.Controllers
{
    public class CursosController : Controller
    {

        public IActionResult Cadastro()
        {
            if (HttpContext.Session.GetInt32("idAdm") == null)
                return RedirectToAction("Login", "Administrador");
            return View();
        }
        [HttpPost]
        public IActionResult Cadastro(Cursos c)
        {
            if (HttpContext.Session.GetInt32("idAdm") == null)
                return RedirectToAction("Login", "Administrador");
            CursosRepository course = new CursosRepository();
            course.Insert(c);
            ViewBag.MsgCadastroC = "Curso Cadastrado com sucesso!";
            return View();
        }
        public IActionResult Listar()
        {
            CursosRepository course = new CursosRepository();
            List<Cursos> cursos = course.Query();
            return View(cursos);
        }
        public IActionResult Excluir(Cursos c)
        {
            if (HttpContext.Session.GetInt32("idAdm") == null)
                return RedirectToAction("Login", "Administrador");
            CursosRepository course = new CursosRepository();
            course.Excluir(c);
            ViewBag.MsgExcluirC = "Curso Excluído com sucesso!";
            return RedirectToAction("Listar");
        }
        public IActionResult Editar(Cursos c)
        {
            if (HttpContext.Session.GetInt32("idAdm") == null)
                return RedirectToAction("Login", "Administrador");
            CursosRepository cs = new CursosRepository();
            cs.Editar(c);
            ViewBag.MsgEditarC = "Curso editado com sucesso";
            return View();
        }
    }
}