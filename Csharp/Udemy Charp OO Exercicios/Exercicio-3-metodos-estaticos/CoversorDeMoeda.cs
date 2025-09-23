using System;

namespace Exercicio_3_metodos_estaticos
{
    public class CoversorDeMoeda
    {
        public static double IOF = 6.0;

        public static double CalcularTotalDolar(double valor, double cotacao)
        {
            double total = valor * cotacao;
            return total + total * IOF / 100;
        }

    }
}