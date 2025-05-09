using System;

namespace ManipulacaoStrings
{
    public class ManipuladorString
    {
        public string Concatenar(string nome, string sobrenome)
        {
            string resultado = $"{nome} {sobrenome}";
            Console.WriteLine($"[Concatenação] -> {resultado}");
            return resultado;
        }

        public string ParaMaiusculas(string nomeCompleto, string sobrenomeIgnorado)
        {
            string resultado = nomeCompleto.ToUpper();
            Console.WriteLine($"[Maiúsculas] -> {resultado}");
            return resultado;
        }

        public string RemoverEspacos(string nomeCompleto, string sobrenomeIgnorado)
        {
            string resultado = nomeCompleto.Replace(" ", "");
            Console.WriteLine($"[Sem espaços] -> {resultado}");
            return resultado;
        }
    }

    public class Questao11
    {
        public static void Executar()
        {
            var manipulador = new ManipuladorString();

            Func<string, string, string> processar;

            processar = manipulador.Concatenar;
            processar += manipulador.ParaMaiusculas;
            processar += manipulador.RemoverEspacos;

            Console.WriteLine("--- Manipulação Encadeada de Strings ---");
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o sobrenome: ");
            string sobrenome = Console.ReadLine();

            string resultadoFinal = processar(nome, sobrenome);

            Console.WriteLine($"\n▶ Resultado final retornado pelo multicaste delegate: {resultadoFinal}");
            Console.WriteLine("Só o resultado do ultimo método é retornado.");
        }
    }
}
