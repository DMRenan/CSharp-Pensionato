using System;

namespace Pensionato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vetorQuartos = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int qtdquartos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdquartos; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vetorQuartos[quarto-1] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vetorQuartos[i] != null)
                {
                    Console.WriteLine(i + ": " + vetorQuartos[i]);
                }
            }
        }
    }
}
