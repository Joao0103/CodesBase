using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 2002;

            int N = int.Parse(Console.ReadLine());

            while (N != senha)
            {
                Console.WriteLine("Senha Inválida");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido");

            Console.ReadLine();

        }
    }
}
