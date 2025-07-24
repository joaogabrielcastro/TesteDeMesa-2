using System;
using System.Globalization;

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

            CultureInfo culturaBrasil = new CultureInfo("pt-BR");

            
            Console.WriteLine("{0,-10} {1,-15} {2,-15} {3,-15} {4,-15} {5,-20}",
                              "Mês", "Loop a.m.", "Taxa Juros", "Rendimento", "Rend. Líquido", "Renda Acumulada");
            Console.WriteLine("----------------------------------------------------------------------------------");

            double valorAtual = valorPresente;
            double jurosAcumulados = 0; 

            for (int mes = 1; mes <= periodoMeses; mes++)
            {
                
                double valorNoInicioDoMes = valorAtual;

                
                double rendimentoNoMes = valorAtual * taxaJurosMensal;

               
                valorAtual += rendimentoNoMes;

                
                jurosAcumulados += rendimentoNoMes;

                
                Console.WriteLine(
                    "{0,-10} {1,-15} {2,-15:P2} {3,-15} {4,-15} {5,-20}",
                    mes,
                    mes,
                    taxaJurosMensal,
                    valorAtual.ToString("C2", culturaBrasil), 
                    jurosAcumulados.ToString("C2", culturaBrasil), 
                    valorAtual.ToString("C2", culturaBrasil) 
                );
            }

            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine($"\nValor Futuro Total após {periodoMeses} meses: {valorAtual.ToString("C2", culturaBrasil)}");
            Console.WriteLine("----------------------------------------------------------------------------------");
        }
    }
}
