using System;
using System.Threading;

namespace GerenciadorDeDownload
{
    public class DownloadManager
    {
        public event EventHandler DownloadCompleted;

        public void IniciarDownload()
        {
            Console.WriteLine("Iniciando download...................");

            Thread.Sleep(3000);

            Console.WriteLine("Processando finalização...");

            DownloadCompleted?.Invoke(this, EventArgs.Empty);
        }
    }

    public class Questao05
    {
        public static void Executar()
        {
            var download = new DownloadManager();
            download.DownloadCompleted += NotificarUsuario;

            download.IniciarDownload();
        }

        private static void NotificarUsuario(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Download concluído");
            Console.ResetColor();
        }
    }
}
