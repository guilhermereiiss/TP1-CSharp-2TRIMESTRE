using System;
using AcoesMultilingues;
using CalculoDeArea;
using TP1_CSHARP_2TRIMESTRE.Questao01;
using MonitoramentoTemperatura;
using GerenciadorDeDownload;
using RegistroLogs;
using LoggerSeguro;
using ManipulacaoStrings;



class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nEscolha a questão para executar:");
            Console.WriteLine("1 - Implementação de Delegate Personalizado para Descontos");
            Console.WriteLine("2 - Ações Multilíngues com Action<string>");
            Console.WriteLine("3 - Cálculo de Área Utilizando Func");
            Console.WriteLine("4 - Monitoramento de Temperatura com Evento Personalizado");
            Console.WriteLine("5 - Notificação de Conclusão de Download com Eventos");
            Console.WriteLine("6 - Sistema de Registro com Multicast Delegate");
            Console.WriteLine("7 - Garantia de Robustez em Invocação de Delegates");
            Console.WriteLine("11 -  Manipulação de Strings com Delegates Encadeados");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");

            string opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "1":
                    DescontoApp.Executar();
                    break;
                case "2":
                    ProgramaMultilingue.Executar();
                    break;
                case "3":
                    CalculoArea.Executar();
                    break;
                case "4":
                    Questao04.Executar();
                    break;
                case "5":--
                    Questao05.Executar();
                    break;
                case "6":
                    Questao06.Executar();
                    break;
                case "7":
                    Questao07.Executar();
                    break;
                case "11":
                    Questao11.Executar();
                    break;
                case "0":
                    Console.WriteLine("Encerrando o programa...");
                    return; 
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
