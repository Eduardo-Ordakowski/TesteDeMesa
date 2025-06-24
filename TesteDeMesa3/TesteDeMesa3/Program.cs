namespace TesteDeMesa3
{
    internal class Program
    {
        public static void Main()
        {
            int option = 0;

            Console.WriteLine("Teste de mesa 3 - Eduardo Ordakowski -");
            Console.WriteLine("Escolha um exercício para visualizar...\n -> Exercicio - 6\n -> Exercicio - 7\n -> Exercicio - 8\n -> Sair - 0");

            option = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (option)
            {
                case 0:
                    Console.WriteLine("Encerrando o programa...");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                    break;

                case 6:
                    Exercicio6.Ex6();
                    break;

                case 7:
                    Exercicio7.Ex7();
                    break;

                case 8:
                    Exercicio8.Ex8();
                    break;
            }
        }
    }
}