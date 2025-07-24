using System;

namespace JurosFinanceirosApp.Problemas
{
    public class Problema5
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("--- Problema 5: Cálculo do Valor Presente para Juros Simples ---");
            Console.WriteLine("--- Baseado na taxa mensal do Problema 2, convertida para anual simples ---");

            double valorFuturo = 7390.61;

           
            double taxaJurosMensal = 0.0125; 

            
            double taxaJurosAnual = taxaJurosMensal * 12; 

            int periodoAnos = 2; 

            Console.WriteLine($"\nValor Futuro (VF): {valorFuturo:C2}");
            Console.WriteLine($"Taxa de Juros Mensal (do Problema 2): {taxaJurosMensal:P2}");
            Console.WriteLine($"Taxa de Juros Anual (derivada para juros simples): {taxaJurosAnual:P2}");
            Console.WriteLine($"Período (t): {periodoAnos} anos\n");

            double valorPresente = valorFuturo / (1 + (taxaJurosAnual * periodoAnos));

            Console.WriteLine($"O Valor Presente (VP) seria: {valorPresente:C2}");
            Console.WriteLine("------------------------------------------------------------------");
        }
    }
}
