namespace TesteDeMesa2
{
    class Program
    {
        public static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            int option = 0;

            Console.WriteLine("Teste de mesa 2 - Eduardo Ordakowski -");
            Console.WriteLine("Escolha um exercício para visualizar...\n -> Exercicio - 1\n -> Exercicio - 2\n -> Exercicio - 3\n -> Exercicio - 4\n -> Exercicio - 5\n" +
            "\n -> Sair - 0");

            option = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (option)
            {
                case 0:
                    Console.WriteLine("Encerrando o programa...");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                    break;

                case 1:
                    Exercicio1.Ex1();
                    break;

                case 2:
                    Exercicio2.Ex2();
                    break;

                case 3:
                    Exercicio3.Ex3();
                    break;

                case 4:
                    Exercicio4.Ex4();
                    break;

                case 5:
                    Exercicio5.Ex5();
                    break;

                default:
                    Console.WriteLine("Insira uma opção valida...");
                    Thread.Sleep(2000);
                    Program.Main();
                    break;
            }

        }
    }
}