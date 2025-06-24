namespace TesteDeMesa2
{
    internal class Exercicio1
    {
        public static void Ex1()
        {

            double ValorPresente;
            double TaxaJuros;
            int Periodo;
            double ValorFuturo;
            int loop = 1;

            Console.WriteLine("Executando Exercicio 1:");
            Console.WriteLine("---------------------------");

            do
            {
                Console.WriteLine("Insira o Valor Presente");
                Console.Write("R$:");
                ValorPresente = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("---------------------------");

                Console.WriteLine("Insira a Taxa de Juros");
                Console.Write("%:");
                TaxaJuros = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("---------------------------");

                Console.WriteLine("Insira o periodo");
                Console.Write("Mes/Meses:");
                Periodo = Convert.ToInt32(Console.ReadLine());

                ValorFuturo = Functions.VF(ValorPresente, TaxaJuros, Periodo);

                Console.WriteLine("---------------------------");

                Console.WriteLine($"|{"Valor presente",15}|{"Taxa de juros",15}|{"Periodo (Meses)",15}|{"Valor futuro",15}|");
                Console.WriteLine($"|{ValorPresente.ToString("C"),15}|{TaxaJuros,14}%|{Periodo,15}|{ValorFuturo.ToString("c"),15}|");

                Console.WriteLine("Resetar exercício 1 -\nSim (1) - Não (0)");
                loop = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            while (loop == 1);
            Console.WriteLine("Encerrando Exercício 1...\nRetornando ao menu ->");
            Program.Main();
            Console.Clear();
        }
    }
}
