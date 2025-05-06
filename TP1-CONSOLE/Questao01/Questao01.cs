using System;

namespace TP1_CSHARP_2TRIMESTRE.Questao01
{
 
    delegate decimal CalcularDesconto(decimal precoOriginal);

    public class DescontoApp
    {

        private static decimal AplicarDescontoPadrao(decimal preco)
        {
            return preco * 0.90m;
        }

        public static void Executar()
        {
            Console.WriteLine("=== Sistema de Desconto ===\n");

            Console.Write("Informe o preço original do produto (R$): ");
            string input = Console.ReadLine();

            if (!decimal.TryParse(input, out decimal precoOriginal) || precoOriginal < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido! Digite um numero positivo valido.");
                Console.ResetColor();
                return;
            }

            var desconto = new CalcularDesconto(AplicarDescontoPadrao);
            decimal precoComDesconto = desconto(precoOriginal);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nPreço com desconto aplicado: R$ {precoComDesconto:F2}");
            Console.ResetColor();
        }
    }
}
