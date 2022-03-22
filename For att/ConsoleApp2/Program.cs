using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.Write($"Valor #{i}:  ");
                int valor = int.Parse(Console.ReadLine());
                soma = soma + valor;
            }
            Console.WriteLine();

            Console.Write("Soma Total = " + soma);
        }
    }
}
