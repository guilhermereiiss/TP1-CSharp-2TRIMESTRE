using System;

namespace CalculoDeArea
{
    public class CalculoArea
    {
        public static void Executar()
        {
            Console.WriteLine("=== Cálculo de Área de um Retângulo ===");

            Console.Write("Informe a base (em metros): ");
            string entradaBase = Console.ReadLine();

            Console.Write("Informe a altura (em metros): ");
            string entradaAltura = Console.ReadLine();

            if (!double.TryParse(entradaBase, out double baseRetangulo) || baseRetangulo <= 0 ||
                !double.TryParse(entradaAltura, out double alturaRetangulo) || alturaRetangulo <= 0)
            {
                Console.WriteLine("Valores inválidos! Digite números positivos.");
                return;
            }

            Func<double, double, double> calcularArea = (b, h) => b * h;

            double area = calcularArea(baseRetangulo, alturaRetangulo);

            Console.WriteLine($"A área do retângulo é: {area:F2} metros quadrados.");
        }
    }
}
