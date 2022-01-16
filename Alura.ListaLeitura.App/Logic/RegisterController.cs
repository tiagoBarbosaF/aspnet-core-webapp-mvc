using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Alura.ListaLeitura.App.Logic
{
    public class RegisterController
    {
        public string Includ(Livro livro)
        {
            var repo = new LivroRepositorioCSV();

            repo.Incluir(livro);

            return "The book has been registered successfully";
        }

        public IActionResult ShowForm()
        {
            var html = new ViewResult { ViewName = "form"};
            return html;
        }
    }
}