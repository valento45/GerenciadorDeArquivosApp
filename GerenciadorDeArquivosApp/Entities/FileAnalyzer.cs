using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeArquivosApp.Entities
{
    public class FileAnalyzer
    {

        public static Dictionary<string, int> AnalyzeExtensions(string directory)
        {
            var result = new Dictionary<string, int>();

            var todosArquivos = Directory.GetFiles(directory).ToList() ?? new List<string>();
            var extensoes = todosArquivos?.Select(x => Path.GetExtension(x.ToString()));


            if (todosArquivos?.Any() ?? false)
            {
                foreach (var extensao in extensoes)
                {
                    var countExtensao = todosArquivos.Count(x => x.Contains(extensao));
                    if (!result.ContainsKey(extensao))
                        result.Add(extensao, countExtensao);
                }
            }

            return result;

        }
    }
}
