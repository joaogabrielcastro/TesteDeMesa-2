using TesteMesa3.Problemas;
using System;

namespace TestedeMesa3
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Teste de Mesa 3 - Problema 6");
        Console.WriteLine("Teste de Mesa 3 - Problema 7");
        Console.WriteLine("Teste de Mesa 3 - Problema 8");
        Console.Write("Digite sua opção: ");

            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "6":
                    Problema6.Executar();
                    break;
                case "7":
                    Problema7.Executar();
                    break;
                case "8":
                    Problema8.Executar();
                    break;

                default:
                    Console.WriteLine("Opção inválida. Pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
