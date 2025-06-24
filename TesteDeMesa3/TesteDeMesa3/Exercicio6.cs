using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TesteDeMesa3
{
    internal class Exercicio6
    {
        public static void Ex6()
        {
            int loop = 1;

            Console.WriteLine("Executando Exercicio 6:");
            Console.WriteLine("---------------------------");

            double[] valorPresente = { 1000, 5500, 12000 }; //Passa os valores baseados na planilha;
            double[] taxaJuros = { 3.0, 2.48, 2.0 }; // e as taxas;
            
            do
            {
                double periodo = Functions.corrigirTempo(); //Corrige os meses para dias e soma com os 10;

            
                for (int i = 0; i < valorPresente.Length; i++)
                {
                    Console.WriteLine($"|{"Valor Presente",15}");
                    Console.WriteLine($"|{valorPresente[i].ToString("C"),15}|\n");

                    double valorFuturo = Functions.valorFuturoDiario(valorPresente[i], taxaJuros[i], periodo);
                    //Faz o calculo aplicando a taxa baseado no periodo todo;

                    Functions.imprimeValores(valorPresente[i], taxaJuros[i], periodo, valorFuturo, 0, 0, 0);
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                }

                Console.WriteLine("Deseja resetar o exercicio?\n Sim(1) - Não (2)");
                loop = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
            }while (loop == 1);

            Console.WriteLine("Retornando para o menu...");
            Thread.Sleep(2000);
            Console.Clear();
            Program.Main();
        }
    }
}
