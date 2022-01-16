using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Alura.ListaLeitura.App.Utils;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Alura.ListaLeitura.App.Logic
{
    public class BookController : Controller
    {
        public IEnumerable<Livro> Books { get; set; }

        public static string LoadList(IEnumerable<Livro> books)
        {
            var fileContent = HtmlUtils.LoadHtmlFile("list");            

            return fileContent.Replace("#NEWITEM#", "");
        }

        public IActionResult ToRead()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Books = _repo.ParaLer.Livros;

            return View("list");
        }

        public IActionResult Reading()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Books = _repo.Lendo.Livros;

            return View("list");
        }

        public IActionResult Readed()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Books = _repo.Lidos.Livros;

            return View("list");
        }


        public string Details(int id)
        {
            var repository = new LivroRepositorioCSV();
            var book = repository.Todos.First(b => b.Id == id);

            return book.Detalhes();
        }

        public string Test()
        {
            return "This is a test MVC default route";
        }
    }
}