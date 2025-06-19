using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa1
{
    public class TM1_exercicio1
    {
        public static void Exercicio1()
        {
            int a = 10;
            int b = 20;
            int c = (a + b) / 2;

            int c2 = c - 40;

            int[] v = new int[4];

            Console.WriteLine($"Valor de A: {a}");
            Console.WriteLine($"Valor de B: {b}");
            Console.WriteLine($"Valor de C: {c}");
            Console.WriteLine($"Valor de C²:{c2}");

            for (int i = 0; i < v.Length; i++)
            {
                if (i == 3)
                {
                    v[i] = a + b + c2;

                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine($"Loop {i + 1}");
                    Console.WriteLine($"Posição do Vetor = {i}\nValor do Vetor = {v[i]}");
                }
                else
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine($"Loop {i + 1}");
                    Console.WriteLine($"Posição do Vetor = {i}\nValor do Vetor = {v[i]}");
                }
            }
        }
    }
}