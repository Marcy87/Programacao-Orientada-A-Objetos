using System.Globalization;

namespace Banco
{
    class Conta
    {
        //Atributos
        public int Numero { get; private set; }  // Auto Properties
        public string Titular { get; set; }
        public double Saldo { get; private set; }  // Auto Properties


        //Construtor
        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, double depInic) : this (numero, titular)
        {
            Deposito(depInic);
        }


        //Métodos
        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= saque + 5.0;
        }



        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
