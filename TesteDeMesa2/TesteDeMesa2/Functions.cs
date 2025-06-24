namespace TesteDeMesa2
{
    internal class Functions
    {
        public static double VF(double ValorPresente, double TaxaJuros, int Periodo)
        {
            TaxaJuros = TaxaJuros / 100;

            double ValorFuturo = ValorPresente * (Math.Pow(TaxaJuros + 1, Periodo));

            return ValorFuturo;
        }

        public static double RL(double ValorFuturo, double VFAnterior)
        {
            double RendLiquida;

            if (VFAnterior == 0)
            {
                return RendLiquida = 0;
            }
            else
            {
                RendLiquida = ValorFuturo - VFAnterior;
                return RendLiquida;
            }
        }

        public static double VP(double ValorFuturo, double TaxaJuros, int Periodo)
        {
            TaxaJuros = TaxaJuros / 100;

            double ValorPresente = ValorFuturo / (Math.Pow(1 + TaxaJuros, Periodo));

            return ValorPresente;
        }

    }
}