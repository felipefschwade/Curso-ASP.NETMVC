using CaelumEstoque.DAO;
using CaelumEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaelumEstoque.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Autentica(Usuario usuario)
        {
            var dao = new UsuariosDAO();
            usuario = dao.Busca(usuario.Nome, usuario.Senha);
            if (usuario != null)
            {
                Session["usuarioLogado"] = usuario;
                return RedirectToAction("Index", "Produtos");
            }
            ModelState.AddModelError("usuario.Invalido", "Usuário ou senha inválidos");
            return View("Index");
        }
    }
}