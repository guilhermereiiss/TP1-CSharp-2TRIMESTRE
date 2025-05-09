using System;

namespace MonitoramentoTemperatura
{
    public class SensorTemperatura
    {
        public event EventHandler<double> TemperaturaExcedida;

        public void Verificar(double temperaturaAtual)
        {
            Console.WriteLine($"Temperatura registrada: {temperaturaAtual}°C");

            if (temperaturaAtual > 100)
            {
                TemperaturaExcedida?.Invoke(this, temperaturaAtual);
            }
        }
    }

    public class Questao04
    {
        public static void Executar()
        {
            var sensor = new SensorTemperatura();
            sensor.TemperaturaExcedida += ExibirAlerta;

            Console.WriteLine("--- Monitoramento de Temperatura ---");

            while (true)
            {
                Console.Write("Digite a temperatura simulada (ou sair): ");
                string entrada = Console.ReadLine();

                if (entrada.ToLower() == "sair")
                    break;

                if (double.TryParse(entrada, out double temperatura))
                {
                    sensor.Verificar(temperatura);
                }
                else
                {
                    Console.WriteLine("Entrada invalida. Tente novamente.");
                }
            }
        }

        private static void ExibirAlerta(object sender, double temperatura)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[ALERTA] Temperatura critica foi ddetectada: {temperatura}°C!");
            Console.ResetColor();
        }
    }
}
