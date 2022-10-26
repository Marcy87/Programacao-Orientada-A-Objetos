using System;

namespace QuartosAlugar
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] estudante = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Aluguel #" + i + ": ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                estudante[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (estudante[i] != null)
                {
                    Console.WriteLine(i + ": " + estudante[i]);
                }
            }
        }
    }
}