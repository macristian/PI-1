using System.Collections.Generic;
using Scisense.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace Scisense.Controllers
{
    public class ConteudoController : Controller
    {

        public IActionResult Cadastro()
        {
            if (HttpContext.Session.GetInt32("idAdm") == null)
                return RedirectToAction("Login", "Administrador");
            return View();
        }
        [HttpPost]
        public IActionResult Cadastro(Conteudo c)
        {
            if (HttpContext.Session.GetInt32("idAdm") == null)
                return RedirectToAction("Login", "Administrador");
            ConteudoRepository course = new ConteudoRepository();
            course.Insert(c);
            ViewBag.MsgCadastroC = "Conteúdo Cadastrado com sucesso!";
            return View();
        }
        public IActionResult Listar()
        {
            ConteudoRepository course = new ConteudoRepository();
            List<Conteudo> cursos = course.Query();
            return View(cursos);
        }
        public IActionResult Excluir(Conteudo c)
        {
            if (HttpContext.Session.GetInt32("idAdm") == null)
                return RedirectToAction("Login", "Administrador");
            ConteudoRepository course = new ConteudoRepository();
            course.Excluir(c);
            ViewBag.MsgExcluirC = "Conteúdo Excluído com sucesso!";
            return RedirectToAction("Listar");
        }
        public IActionResult Editar(Conteudo c)
        {
            if (HttpContext.Session.GetInt32("idAdm") == null)
                return RedirectToAction("Login", "Administrador");
            ConteudoRepository ct = new ConteudoRepository();
            ct.Editar(c);
            ViewBag.MsgEditarC = "Curso editado com sucesso";
            return View();
        }
    }
}