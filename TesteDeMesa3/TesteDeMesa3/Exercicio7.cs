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
    internal class Exercicio7
    {
        public static void Ex7()
        {
            int loop = 1;
            do
            {
                var (valorPresente, taxaJuros, periodo) = Functions.capturaValores();
                double dias = periodo; //Guardar os dias para o loop;

                periodo = 0;
                double saldo = valorPresente;
                double saque;

                Console.WriteLine($"|{"Valor Presente"}");
                Console.WriteLine($"|{valorPresente.ToString("C"),15}|\n");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

                for (int i = 1; i <= dias; i++)
                {
                    double valorFuturo = Functions.valorFuturoDiario(valorPresente, taxaJuros, 1); //Calcula o juros por dia.

                    double rendLiq = valorFuturo - valorPresente; //Rendimento líquido é calculado com base no valor futuro e no valor presente;

                    saldo += rendLiq; //Saldo recebeu o valor presente e vai se atualizando com rendLiq;

                    if (i == 150) //Aprox mes 5
                    {
                        saque = 1000;
                        saldo -= saque; //Recalcula o saldo dps do saque;
                        valorPresente = saldo; //Valor presente (Base de calculo) é atualizada;
                        periodo = 0; //Periodo resetado;

                        Functions.imprimeValores(valorPresente, taxaJuros, i, valorFuturo, rendLiq, saque, saldo);
                        //Imprime novamente dps do saque mas antes de att o valor futuro, fica mais claro a saida de valores e tals;

                        valorFuturo = Functions.valorFuturoDiario(valorPresente, taxaJuros, periodo); //Recalcula o valor futuro baseado nos dados atualizados;
                    }
                    else
                    {
                        saque = 0;
                        Functions.imprimeValores(valorPresente, taxaJuros, i, valorFuturo, rendLiq, saque, saldo);
                    }
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
