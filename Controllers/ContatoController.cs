using System.Collections.Generic;
using Scisense.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;

namespace Scisense.Controllers
{
    public class ContatoController : Controller
    {

        public IActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastro(Contato c)
        {
            ContatoRepository cont = new ContatoRepository();
            cont.Insert(c);
            ViewBag.MsgCadastroCont = "Obrigado pelo seu contato! Em breve entraremos em contato com você";
            return View();
        }
        public IActionResult Listar()
        {
            if (HttpContext.Session.GetInt32("idAdm") == null)
                return RedirectToAction("Login", "Administrador");
            ContatoRepository cont = new ContatoRepository();
            List<Contato> contatos = cont.Query();
            return View(contatos);
        }
        public IActionResult Excluir(Contato c)
        {
            if (HttpContext.Session.GetInt32("idAdm") == null)
                return RedirectToAction("Login", "Administrador");
            ContatoRepository cont = new ContatoRepository();
            cont.Excluir(c);
            ViewBag.MsgExcluirP = "Contato Excluído com sucesso!";
            return RedirectToAction("Listar");
        }
        public IActionResult Editar(Contato c)
        {
            if (HttpContext.Session.GetInt32("idAdm") == null)
                return RedirectToAction("Login", "Administrador");
            ContatoRepository course = new ContatoRepository();
            course.Editar(c);
            return RedirectToAction("Listar");
        }
    }
}