using System; 

namespace JurosFinanceirosApp.Problemas
{
    public class Problema1 
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("--- Problema 1: Cálculo de Juros Compostos ---");

            try
            {
                Console.Write("Digite o Valor Presente (P): ");
                double valorPresente = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a Taxa de Juros Mensal (ex: 0.053 para 5.3%): ");
                double taxaJurosMensal = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o Período em Meses (n): ");
                int periodoMeses = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n--- Tabela de Rendimento ---");
                Console.WriteLine("{0,-10} {1,-15} {2,-15} {3,-15}", "Mês", "Valor Inicial", "Rendimento", "Valor Final");
                Console.WriteLine("------------------------------------------------------------------");

                double valorAtual = valorPresente;

                for (int mes = 1; mes <= periodoMeses; mes++)
                {
                    double rendimentoMes = valorAtual * taxaJurosMensal;
                    double valorFinalMes = valorAtual + rendimentoMes;

                    Console.WriteLine("{0,-10} {1,-15:C2} {2,-15:C2} {3,-15:C2}", mes, valorAtual, rendimentoMes, valorFinalMes);

                    valorAtual = valorFinalMes;
                }

                Console.WriteLine($"\nValor Futuro Total após {periodoMeses} meses: {valorAtual:C2}");
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