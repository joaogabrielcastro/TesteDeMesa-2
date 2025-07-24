using System;

namespace JurosFinanceirosApp.Problemas
{
    public class Problema4
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("--- Problema 4: Tabela com Resgate ---");

            try
            {
                Console.Write("Digite o Valor Presente (P): ");
                double valorPresente = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a Taxa de Juros Mensal (ex: 0.02 para 2%): ");
                double taxaJurosMensal = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o Período em Meses (n): ");
                int periodoMeses = Convert.ToInt32(Console.ReadLine());

                Console.Write("Em qual mês (1 a n) ocorrerá o resgate? ");
                int mesResgate = Convert.ToInt32(Console.ReadLine());

                Console.Write("Qual o valor do resgate? ");
                double valorResgate = Convert.ToDouble(Console.ReadLine());

                
                if (mesResgate <= 0 || mesResgate > periodoMeses)
                {
                    Console.WriteLine("Erro: Mês de resgate inválido. Deve estar entre 1 e o período total de meses.");
                    return;
                }
                if (valorResgate < 0)
                {
                    Console.WriteLine("Erro: O valor do resgate não pode ser negativo.");
                    return; 
                }

                Console.WriteLine("\n--- Tabela de Rendimento com Resgate ---");
                Console.WriteLine("{0,-10} {1,-15} {2,-15} {3,-15} {4,-20}", "Mês", "Valor Inicial", "Rendimento Mes", "Valor Antes Resg.", "Saldo/Resgate Info");
                Console.WriteLine("------------------------------------------------------------------------------------------");

                double valorAtual = valorPresente;

                for (int mes = 1; mes <= periodoMeses; mes++)
                {
                    double rendimentoMes = valorAtual * taxaJurosMensal;
                    double valorAntesResgate = valorAtual + rendimentoMes;
                    double saldoPosResgate = valorAntesResgate;
                    string infoResgate = "";

                    if (mes == mesResgate)
                    {
                        if (valorResgate > valorAntesResgate)
                        {
                            Console.WriteLine($"Aviso: O valor do resgate ({valorResgate:C2}) é maior que o saldo atual ({valorAntesResgate:C2}).");
                            saldoPosResgate = 0;
                            infoResgate = $"Resgate de {valorAntesResgate:C2} (saldo esgotado)";
                        }
                        else
                        {
                            saldoPosResgate -= valorResgate;
                            infoResgate = $"Resgate de {valorResgate:C2}";
                        }
                    }

                    Console.WriteLine("{0,-10} {1,-15:C2} {2,-15:C2} {3,-15:C2} {4,-20}", mes, valorAtual, rendimentoMes, valorAntesResgate, infoResgate);

                    valorAtual = saldoPosResgate; 
                }

                Console.WriteLine($"\nSaldo Final Total após {periodoMeses} meses: {valorAtual:C2}");
                Console.WriteLine("------------------------------------------------------------------------------------------");
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