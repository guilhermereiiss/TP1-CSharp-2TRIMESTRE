using System;
using System.IO;

namespace LoggerSeguro
{
    public class Logger
    {
        public void LogarNoConsole(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"[Console] {mensagem}");
            Console.ResetColor();
        }

        public void LogarNoArquivo(string mensagem)
        {
            File.AppendAllText("log_seguro.txt", $"[Arquivo] {mensagem}{Environment.NewLine}");
        }

        public void LogarNoBanco(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[Banco] (Simulado) {mensagem}");
            Console.ResetColor();
        }
    }

    public class Questao07
    {
        public static void Executar()
        {
            var logger = new Logger();
            Action<string> registrarLog = null;

            Console.WriteLine("--- Sistema de Registro Seguro ---");
            Console.Write("Deseja associar os métodos de log? (s/n): ");
            string opcao = Console.ReadLine();

            if (opcao.Trim().ToLower() == "s")
            {
                registrarLog += logger.LogarNoConsole;
                registrarLog += logger.LogarNoArquivo;
                registrarLog += logger.LogarNoBanco;
            }

            Console.Write("Digite a mensagem para registrar: ");
            string mensagem = Console.ReadLine();

            registrarLog?.Invoke(mensagem);

            Console.WriteLine("\n✔ Tentativa de log concluída. Nenhuma exceção foi lançada.");
        }
    }
}
