using System;

namespace JurosFinanceirosApp.Problemas
{
    public class Problema5
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("--- Problema 5: Cálculo Inverso (Encontrar Valor Presente) ---");

          
            double valorFuturoDesejado = 7390.61;
            double taxaJurosMensal = 0.0125; 
            int periodoMeses = 6; 

            Console.WriteLine($"Valor Futuro Desejado: {valorFuturoDesejado:C2}");
            Console.WriteLine($"Taxa de Juros Mensal: {taxaJurosMensal:P2}");
            Console.WriteLine($"Período: {periodoMeses} meses\n");

           
            double fatorAcumulacao = Math.Pow((1 + taxaJurosMensal), periodoMeses);

 
            double valorPresenteNecessario = valorFuturoDesejado / fatorAcumulacao;

            Console.WriteLine("--- Resultados ---");
            Console.WriteLine($"Para atingir um Valor Futuro de {valorFuturoDesejado:C2}");
            Console.WriteLine($"Com uma Taxa de {taxaJurosMensal:P2} a.m. por {periodoMeses} meses,");
            Console.WriteLine($"Você precisaria investir um Valor Presente de: {valorPresenteNecessario:C2}");
            Console.WriteLine("------------------------------------------------------------------");
        }
    }
}