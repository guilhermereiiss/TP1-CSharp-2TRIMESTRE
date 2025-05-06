using System;
using AcoesMultilingues;
using CalculoDeArea;
using TP1_CSHARP_2TRIMESTRE.Questao01;

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
            Console.WriteLine("4 - Manipulação de Datas - Dias até o Próximo Aniversário");
            Console.WriteLine("5 - Tempo Restante para Conclusão do Curso - Diferença Entre Datas");
            Console.WriteLine("6 - Cadastro de Alunos");
            Console.WriteLine("7 - Banco Digital (Encapsulamento)");
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
                //case "4":
                //    Questao04.Executar();
                //    break;
                //case "5":
                //    Questao05.Executar();
                //    break;
                //case "6":
                //    Aluno.Executar();
                //    break;
                //case "7":
                //    ContaBancaria.Executar();
                //    break;
                case "0":
                    Console.WriteLine("Encerrando o programa...");
                    return; // Encerra o método Main e finaliza o programa
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
