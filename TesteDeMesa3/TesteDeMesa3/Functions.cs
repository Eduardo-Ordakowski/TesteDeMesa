using System.Diagnostics;

namespace TesteDeMesa3
{
    internal class Functions
    {
        public static double corrigirTempo() //Corrigir tempo;
        {
            Console.WriteLine("Informe os meses:");
            int meses = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe os dias:");
            int dias = Convert.ToInt32(Console.ReadLine());

            DateTime atual = DateTime.Today; //Recebe a data atual (apenas os dias)

            DateTime futura = atual.AddMonths(meses).AddDays(dias); //Adiciona os valores em uma variavel DateTime;

            return ((futura - atual).TotalDays);
        }
        public static double valorFuturoMensal(double ValorPresente, double TaxaJuros, double Periodo) //Valor futuro;
        {
            TaxaJuros = TaxaJuros / 100;

            double ValorFuturo = ValorPresente * (Math.Pow(TaxaJuros + 1, Periodo));

            return ValorFuturo;
        }
        public static double valorFuturoDiario(double valorPresente, double taxaJuros, double periodo)
        {
            // Converte a taxa mensal para diária
            double taxaJurosDiaria = Math.Pow(1 + (taxaJuros / 100), 1.0 / 30.0) - 1;

            // Calcula o valor futuro com juros compostos diários
            double valorFuturo = valorPresente * Math.Pow(1 + taxaJurosDiaria, periodo);

            return valorFuturo;
        }

        public static void imprimeValores (double valorPresente, double taxaJuros, double periodo, double valorFuturo, double rendLiq, double saque, double saldo)
        {

            Console.WriteLine($"|{"Período",15}|{"Taxa de Juros",13}|{"Rendimento",15}" +
                              $"|{"Rend. Líquido",15}|{"Saque",15}|{"Saldo",15}|");

            Console.WriteLine($"|{periodo,15}|{taxaJuros,12}%|{valorFuturo.ToString("C"),15}|" +
                              $"{rendLiq.ToString("C"),15}|{saque.ToString("C"),15}|{saldo.ToString("C"),15}|");

        }

        public static (double valorPresente, double taxaJuros, double periodo) capturaValores()
        {
            Console.WriteLine("Insira o Valor Presente");
            Console.Write("R$:");
            double valorPresente = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("---------------------------");

            Console.WriteLine("Insira a Taxa de Juros");
            Console.Write("%:");
            double taxaJuros = Convert.ToDouble(Console.ReadLine());

            double periodo;
            Console.WriteLine("---------------------------");
          
            periodo = corrigirTempo();
    
            Console.WriteLine("---------------------------");
            
            return (valorPresente,taxaJuros, periodo);
        }
    }
}
