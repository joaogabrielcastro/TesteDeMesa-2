using JurosFinanceirosApp.Problemas;
using System;

namespace JurosFinanceirosApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            bool sair = false;
            while (!sair)
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("    Sistema de Cálculos Financeiros (Juros)   ");
                Console.WriteLine("==============================================");
                Console.WriteLine("Escolha um problema para executar:");
                Console.WriteLine("1. Problema 1: Juros Compostos (Iteração)");
                Console.WriteLine("2. Problema 2: Tabela de Rendimento Mensal Específico");
                Console.WriteLine("3. Problema 3: Programa para Calcular Rendimento Geral");
                Console.WriteLine("4. Problema 4: Tabela com Resgate (Saque)");
                Console.WriteLine("5. Problema 5: Cálculo Inverso (Encontrar Valor Presente)");
                Console.WriteLine("0. Sair");
                Console.WriteLine("==============================================");
                Console.Write("Digite sua opção: ");

                string? opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Problema1.Executar(); 
                        break;
                    case "2":
                        Problema2.Executar(); 
                        break;
                    case "3":
                        Problema3.Executar(); 
                        break;
                    case "4":
                        Problema4.Executar();
                        break;
                    case "5":
                        Problema5.Executar(); 
                        break;
                    case "0":
                        sair = true;
                        Console.WriteLine("Saindo do programa. Obrigado!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Pressione qualquer tecla para tentar novamente.");
                        Console.ReadKey();
                        break;
                }

                if (!sair)
                {
                    Console.WriteLine("\nPressione qualquer tecla para retornar ao menu...");
                    Console.ReadKey();
                }
            }
        }
    }
}