namespace TesteDeMesa2
{
    internal class Exercicio2
    {
        public static void Ex2()
        {
            int loop = 1;

            Console.WriteLine("Executando Exercico 2:");
            Console.WriteLine("----------------------------");

            do
            {
                double ValorPresente = 3800.00d;
                double TaxaJuros = 1.25d;
                int Periodo = 0;
                double ValorFuturo = 0;
                double RendLiquida;
                double RendAcumulada = 0;
                double VFAnterior = 0;

                Console.WriteLine($"|Valor Presente:{ValorPresente.ToString("C")}|");
                Console.WriteLine("----------------------------");
                Console.WriteLine($"|{"Periodo (Meses)",15}|{"Taxa de juros",15}|{"Rendimento",15}|{"Rend. Liquido",15}|{"Renda Acumulada",15}");

                for (int i = 0; i <= 6; i++)
                {
                    ValorFuturo = Functions.VF(ValorPresente, TaxaJuros, Periodo);
                    RendLiquida = Functions.RL(ValorFuturo, VFAnterior);
                    RendAcumulada += RendLiquida;

                    Console.WriteLine($"|{Periodo,15}|{TaxaJuros,14}%|{ValorFuturo.ToString("C"),15}|{RendLiquida.ToString("C"),15}|{RendAcumulada.ToString("C"),15}");

                    Periodo++;
                    VFAnterior = ValorFuturo;
                }

                Console.WriteLine("Resetar exercício 2 -\nSim (1) - Não (0)");
                loop = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            while (loop == 1);
            Console.WriteLine("Encerrando Exercício 2...\nRetornando ao menu ->");
            Program.Main();
            Console.Clear();
        }
    }
}
