using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa1
{
    public class TM1_exercicio3
    {
        public static void Exercicio3()
        {
            int a = 7;
            int b = a - 6;
            int[] v = new int[a];
            int count = 0;

            while(b<a)
            {
                v[b] = b + a;

                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Posição: {count}");
                Console.WriteLine($"Valor de B = {b} || Valor de V = {v[b]}");
                
                b += 2;
                count++;
            }

            Console.WriteLine("\nResultado final:");
            Console.WriteLine($"Posição: {count}\nValor de B = {b} || Valor de V = {b + a}");
        }
    }
}
