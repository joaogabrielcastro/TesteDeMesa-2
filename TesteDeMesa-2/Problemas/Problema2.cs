using System;

namespace JurosFinanceirosApp.Problemas
{
    public class Problema2
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("--- Problema 2: Tabela de Rendimento Mensal Específico ---");

           
            double valorPresente = 3800.00;
            double taxaJurosMensal = 0.0125;
            int periodoMeses = 6;

            Console.WriteLine($"\nValor Presente: {valorPresente:C2}");
            Console.WriteLine($"Taxa de Juros: {taxaJurosMensal:P2} a.m.");
            Console.WriteLine($"Período: {periodoMeses} meses\n");

            Console.WriteLine("{0,-10} {1,-15} {2,-15} {3,-15}", "Mês", "Loop a.m.", "Taxa Juros", "Rendimento Acumulado");
            Console.WriteLine("------------------------------------------------------------------");

            double valorAtual = valorPresente;

            for (int mes = 1; mes <= periodoMeses; mes++)
            {
                double rendimentoNoMes = valorAtual * taxaJurosMensal;
                valorAtual += rendimentoNoMes; 

                
                Console.WriteLine("{0,-10} {1,-15} {2,-15:P2} {3,-15:C2}", mes, mes, taxaJurosMensal, valorAtual);
            }

            Console.WriteLine($"\nValor Futuro Total após {periodoMeses} meses: {valorAtual:C2}");
            Console.WriteLine("------------------------------------------------------------------");
        }
    }
}