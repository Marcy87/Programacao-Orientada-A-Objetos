namespace ExerConvDeMoeda
{
    class ConversorDeMoeda
    {
        public double cotacao;
        public double dolar;

        public static double Iof = 6.0;

        public static double DolarParaReal(double cotacao, double dolar)
        {
            double calculo = cotacao * dolar;
            return calculo + calculo * Iof / 100.0;
        }
    }
}
