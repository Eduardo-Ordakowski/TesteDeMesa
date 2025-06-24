namespace TesteDeMesa2
{
    internal class Exercicio5
    {
        public static void Ex5()
        {
            int loop = 1;

            Console.WriteLine("Executando Exercicio 5:");
            Console.WriteLine("---------------------------");

            do
            {
                //Calculos para obter o valor presente, utilizando a formula VP = VF/ (1 + i);

                double ValorPresente = 0;
                double ValorFuturo = 7390.61;
                double TaxaJuros = 1.25;
                int Periodo = 24;

                Console.WriteLine("Descobrindo qual os valores para que Valor Futuro seja igual a R$7.390,61.");
                Console.WriteLine("Seguindo a forumla, VP = VF/ (1 + i)");

                Console.WriteLine($"|{"Valor presente",15}|{"Taxa de juros",15}|{"Periodo (Meses)",15}|{"Valor futuro",15}|");
                Console.WriteLine($"|{'?',15}|{TaxaJuros,14}%|{Periodo,15}|{ValorFuturo.ToString("c"),15}|");

                ValorPresente = Functions.VP(ValorFuturo, TaxaJuros, Periodo); // Calcula o valor presente baseado na formula;
                ValorFuturo = Functions.VF(ValorPresente, TaxaJuros, Periodo); //Tira a prova real se o valor bate;

                Console.WriteLine($"|{ValorPresente.ToString("C"),15}|{TaxaJuros,14}%|{Periodo,15}|{ValorFuturo.ToString("c"),15}|");

                Console.WriteLine("Resetar exercício 5 -\nSim (1) - Não (0)");

                loop = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            while (loop == 1);
            Console.WriteLine("Encerrando Exercício 5...\nRetornando ao menu ->");
            Program.Main();
            Console.Clear();
        }
    }
}
