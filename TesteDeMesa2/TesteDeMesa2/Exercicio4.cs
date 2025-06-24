namespace TesteDeMesa2
{
    internal class Exercicio4
    {
        public static void Ex4()
        {
            int loop = 1;

            Console.WriteLine("Executando Exercicio 4:");
            Console.WriteLine("---------------------------");

            do
            {
                double ValorPresente;
                double TaxaJuros;
                int Periodo = 0;
                double ValorFuturo = 0;
                double RendLiquida;
                double RendAcumulada = 0;
                double VFAnterior = 0;
                double Saque = 0;
                double Saldo = 0;

                Console.WriteLine("Insira o Valor Presente");
                Console.Write("R$:");
                ValorPresente = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("---------------------------");

                Console.WriteLine("Insira a Taxa de Juros");
                Console.Write("%:");
                TaxaJuros = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("---------------------------");

                Console.WriteLine($"|Valor Presente:{ValorPresente.ToString("C")}|");
                Console.WriteLine("----------------------------");

                Console.WriteLine($"|{"Periodo (Meses)",15}|{"Taxa de juros",15}|{"Rendimento",15}|{"Rend. Liquido",15}|{"Renda Acumulada",15}|{"Saque",15}|{"Saldo",15}");

                for (int i = 0; i <= 6; i++)
                {
                    ValorFuturo = Functions.VF(ValorPresente, TaxaJuros, Periodo);
                    RendLiquida = Functions.RL(ValorFuturo, VFAnterior);
                    RendAcumulada += RendLiquida;

                    Saque = 0;

                    if (i == 5) //Entra no laço no mes 5;
                    {
                        Saque = 1000d;
                        Saldo = VFAnterior + RendLiquida - Saque; //Recalcula o saldo dps do saque;
                        ValorPresente = Saldo; //Valor presente (Base de calculo) é atualizada;
                        Periodo = 0; //Periodo resetado;

                        Console.Write($"|{i,15}|{TaxaJuros,14}%|{ValorFuturo.ToString("C"),15}|{RendLiquida.ToString("C"),15}|{RendAcumulada.ToString("C"),15}|");

                        Console.ForegroundColor = ConsoleColor.Red;//Aqui começa a bananagem;
                        
                        Console.Write($"{Saque.ToString("C"),15}|");
                        
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black; //Aqui encerra a bananagem;
                        
                        Console.WriteLine($"{Saldo.ToString("C"),15}|");
                        //Imprime os dados com o saque, porém mantem o rendimento sem alterar, seguindo a planilha;
                        //Dessa forma, não gera bugs visuais no console. Apos isso, os valores são atualizados. Disclaimer: Pode ser que seja gambiarra!;
                        ValorFuturo = Functions.VF(ValorPresente, TaxaJuros, Periodo); //Recalcula o valor futuro baseado nos dados atualizados;
                    }
                    else
                    {
                        Saldo = ValorFuturo - Saque; //Segue logica normalmente;

                        Console.WriteLine($"|{i,15}|{TaxaJuros,14}%|{ValorFuturo.ToString("C"),15}|{RendLiquida.ToString("C"),15}|{RendAcumulada.ToString("C"),15}|" +
                        $"{Saque.ToString("C"),15}|{Saldo.ToString("C"),15}|");
                    }
                     VFAnterior = ValorFuturo;   //Auxiliar para o cálculo do rendimento líquido;
                    Periodo++;
                }

                Console.WriteLine("Resetar exercício 4 -\nSim (1) - Não (0)");

                loop = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            while (loop == 1);
            Console.WriteLine("Encerrando Exercício 4...\nRetornando ao menu ->");
            Program.Main();
            Console.Clear();
        }
    }
}