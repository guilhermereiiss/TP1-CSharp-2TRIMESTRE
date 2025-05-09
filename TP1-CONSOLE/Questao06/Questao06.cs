using System;
using System.IO;

namespace RegistroLogs
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
            File.AppendAllText("log.txt", $"[Arquivo] {mensagem}{Environment.NewLine}");
        }

        public void LogarNoBanco(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[Banco] (Simulado) {mensagem}");
            Console.ResetColor();
        }
    }

    public class Questao06
    {
        public static void Executar()
        {
            var logger = new Logger();

            Action<string> registrarLog = null;
            registrarLog += logger.LogarNoConsole;
            registrarLog += logger.LogarNoArquivo;
            registrarLog += logger.LogarNoBanco;

            Console.WriteLine("--- Sistema de Registro de Logs ---");
            Console.Write("Digite a mensagem para registrar: ");
            string mensagem = Console.ReadLine();

            if (registrarLog != null)
            {
                registrarLog(mensagem); 
            }

            Console.WriteLine("\n✔ Logs registrados com sucesso.");
        }
    }
}
