using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa1
{
    public class TM1_exercicio2
    {
        public static void Exercicio2()
        {
            int a = 2;
            int[] v = new int[6];

            while (a < 6)
            {
                v[a] = 10 * a;

                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"Valor de A = {a} || Valor de V = {v[a]}");

                a += 1;
            }

            Console.WriteLine("\nResultado final:");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Valor de A = {a} || Valor de V = {a * 10}");

        }
    }
}

