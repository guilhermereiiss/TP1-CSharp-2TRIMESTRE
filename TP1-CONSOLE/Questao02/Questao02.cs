using System;
using System.Collections.Generic;

namespace AcoesMultilingues
{
    class ProgramaMultilingue
    {
        public static void Executar()
        {
            Console.WriteLine("=== Bem-vindo ao Sistema Multilíngue ===");
            Console.WriteLine("Escolha um idioma:");
            Console.WriteLine("1 - Português");
            Console.WriteLine("2 - Inglês");
            Console.WriteLine("3 - Espanhol");

            Console.Write("Digite o número da opção: ");
            string escolha = Console.ReadLine();

            Dictionary<string, Action<string>> mensagens = new Dictionary<string, Action<string>>
            {
                { "1", (nome) => Console.WriteLine($"Olá, {nome}! Seja bem-vindo!") },
                { "2", (nome) => Console.WriteLine($"Hello, {nome}! Welcome!") },
                { "3", (nome) => Console.WriteLine($"¡Hola, {nome}! ¡Bienvenido!") }
            };

            Console.Write("Digite seu nome: ");
            string nomeUsuario = Console.ReadLine();

            if (mensagens.ContainsKey(escolha))
            {
                Action<string> saudacao = mensagens[escolha];
                saudacao(nomeUsuario);
            }
            else
            {
                Console.WriteLine("Idioma não reconhecido.");
            }
        }
    }
}
