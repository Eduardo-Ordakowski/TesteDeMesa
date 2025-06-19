using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Exercicios();
        }
        public static void Exercicios()
        {
            Console.WriteLine("Resolução dos exercícios:\n");
            Thread.Sleep(1000);

            Console.WriteLine("\nExercio 1:");
            TM1_exercicio1.Exercicio1();
            Console.ReadLine();

            Console.WriteLine("\nExercio 2:");
            TM1_exercicio2.Exercicio2();
            Console.ReadLine();

            Console.WriteLine("\nExercio 3:");
            TM1_exercicio3.Exercicio3();
            Console.ReadKey();
        }
    }
}
