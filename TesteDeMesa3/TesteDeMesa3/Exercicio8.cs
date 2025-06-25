using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa3
{
    internal class Exercicio8
    {
        public static void Ex8()
        {
            int loop = 1;

            do
            {
                var (valorPresente, taxaJuros, periodo) = Functions.capturaValores();
                double meses = periodo / 30; //Converte em mes para o loop;

                Console.WriteLine("Escolha o mês de saque:");
                int dataSaque = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Qual o valor de saque?");
                double valorSaque = Convert.ToDouble(Console.ReadLine());

                periodo = 0;
                double saldo = valorPresente;
                double saque;

                Console.WriteLine($"|{"Valor Presente"}");
                Console.WriteLine($"|{valorPresente.ToString("C"),15}|\n");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

                for (int i = 0; i <= meses; i++)
                {
                    double valorFuturo = Functions.valorFuturoMensal(valorPresente, taxaJuros, periodo); //Calcula o juros por dia.

                    double rendLiq = valorFuturo - valorPresente;

                    saldo = valorFuturo; //Saldo recebeu o valor presente e vai se atualizando com rendLiq;

                    if (i == dataSaque) //Aprox mes 5
                    {
                        saque = valorSaque;
                        saldo -= saque; //Recalcula o saldo dps do saque;
                        valorPresente = saldo; //Valor presente (Base de calculo) é atualizada;
                        periodo = 0; //Periodo resetado;
                        valorFuturo = Functions.valorFuturoMensal(valorPresente, taxaJuros, periodo); //Recalcula o valor futuro baseado nos dados atualizados;
                    }
                    else
                    {
                        saque = 0;
                        Functions.imprimeValores(valorPresente, taxaJuros, i, valorFuturo, rendLiq, saque, saldo);
                    }
                    periodo++;
                }
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("Deseja resetar o exercicio?\n Sim(1) - Não (2)");
                loop = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
            } while (loop == 1);

            Console.WriteLine("Retornando para o menu...");
            Thread.Sleep(2000);
            Console.Clear();
            Program.Main();
        }
    }
}
