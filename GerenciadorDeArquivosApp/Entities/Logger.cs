using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeArquivosApp.Entities
{
    public class Logger
    {

        public void LogActivity(string message)
        {
            var fileName = "activity_log.txt";
            var directory = Directory.GetCurrentDirectory();

            string valor = $"{DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss")}: {message}";


            File.WriteAllText(Path.Combine(directory, fileName), valor);
        }

    }
}
