using System;

namespace JurosFinanceirosApp.Problemas
{
    public class Problema3
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("--- Problema 3: Calcular Rendimento Geral ---");

            try
            {
                Console.Write("Digite o Valor Presente (P): ");
                double valorPresente = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a Taxa de Juros Anual (ex: 0.10 para 10%): ");
                double taxaJurosAnual = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o Período em Anos (n): ");
                double periodoAnos = Convert.ToDouble(Console.ReadLine());


                double valorFuturo = valorPresente * Math.Pow((1 + taxaJurosAnual), periodoAnos);
                double rendimentoTotal = valorFuturo - valorPresente;

                Console.WriteLine("\n--- Resultados ---");
                Console.WriteLine($"Valor Presente: {valorPresente:C2}");
                Console.WriteLine($"Taxa de Juros Anual: {taxaJurosAnual:P2}");
                Console.WriteLine($"Período: {periodoAnos} anos");
                Console.WriteLine($"Valor Futuro: {valorFuturo:C2}");
                Console.WriteLine($"Rendimento Total: {rendimentoTotal:C2}");
                Console.WriteLine("------------------------------------------------------------------");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Entrada inválida. Por favor, digite um número válido.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}