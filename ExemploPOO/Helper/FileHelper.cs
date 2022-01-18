using System.IO;

namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
          var retornoCaminho = Directory.GetDirectories(caminho,"*", SearchOption.AllDirectories);

          foreach(var retorno in retornoCaminho)
          {
              System.Console.WriteLine(retorno);
          }
        }

        public void ListarArquivosDiretorios(string caminho)
        {
            var retornoArquivos = Directory.GetFiles(caminho, "*2*", SearchOption.AllDirectories);

            foreach(var retorno in retornoArquivos)
            {
                System.Console.WriteLine(retorno);
            }
        }
    }
}