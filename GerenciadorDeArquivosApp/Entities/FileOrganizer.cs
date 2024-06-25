using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeArquivosApp.Entities
{
    public class FileOrganizer
    {

        public static void OrganizeFiles(string sourceDirectory, string destinationDirectory)
        {
            var directory = Path.GetDirectoryName(destinationDirectory);
            var fileName = Path.GetFileName(sourceDirectory);            



            File.Move(sourceDirectory, Path.Combine(directory, fileName));
        }
    }
   


   

}
