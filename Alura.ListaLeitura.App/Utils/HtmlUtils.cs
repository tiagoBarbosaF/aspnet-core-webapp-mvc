using System.IO;

namespace Alura.ListaLeitura.App.Utils
{
    public class HtmlUtils
    {
        public static string LoadHtmlFile(string fileName)
        {
            var completeFileName = @$"C:\Users\tiago.farias\dev\Alura\DotNet\Alura.ListaLeitura\Alura.ListaLeitura.App\Views\{fileName}.html";
            using(var file = File.OpenText(completeFileName))
            {
                return file.ReadToEnd();
            }
        }
    }
}