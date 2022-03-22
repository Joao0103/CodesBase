using System;
using System.Globalization;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 2002;

            int N = int.Parse(Console.ReadLine());

            while (N != senha)
            {

                Console.WriteLine("Acesso Negado");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
            senha = int.Parse(Console.ReadLine());

            Console.ReadLine();
        }
    }
}
