using Livraria.DAO;
using Livraria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Livraria.Controllers
{
    public class LivroController : Controller
    {
        // GET: Livro
        public ActionResult Index()
        {
            LivroDAO dao = new LivroDAO();
            IList<Livro> lista = dao.Lista();
            return View(lista);
        }

        public ActionResult Novo()
        {
            var model = new Livro();
            return View(model);
        }

        [HttpPost]
        public ActionResult Adiciona(Livro livro)
        {
            if (ModelState.IsValid)
            {
                LivroDAO dao = new LivroDAO();
                dao.Adiciona(livro);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Novo");
            }
        }

        [HttpGet]
        public ActionResult RemoveLivro(int id)
        {
            LivroDAO dao = new LivroDAO();
            dao.Remove(id);
            return RedirectToAction("Index");
        }

        public ActionResult Visualiza(int id)
        {
            LivroDAO dao = new LivroDAO();
            Livro livro = dao.BuscaPorId(id);
            return View(livro);
        }

        [HttpPost]
        public ActionResult EditaLivro(Livro livro)
        {
            if (ModelState.IsValid)
            {
                LivroDAO dao = new LivroDAO();
                dao.Atualiza(livro);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Visualiza", livro);
            }
        }

        public ActionResult PublicaLivro(int id)
        {
            LivroDAO dao = new LivroDAO();
            dao.Publica(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult CategoriaAutocomplete(string termoDigitado)
        {
            LivroDAO dao = new LivroDAO();
            var model = dao.ListaCategoriasQueContemTermo(termoDigitado);
            return Json(model);
        }


    }
}