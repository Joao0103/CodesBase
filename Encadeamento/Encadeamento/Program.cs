using System;

namespace Encadeamento
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y, Z;
            string[] vet = Console.ReadLine().Split(' ');

            X = int.Parse(vet[0]);
            Y = int.Parse(vet[1]);
            Z = int.Parse(vet[2]);

            if (X < Y && X < Z)
            {
                Console.WriteLine("MENOR = " + X);

            }
            else
            {
                if (Y < Z)
                {
                    Console.WriteLine("MENOR = " + Y);
                }
                else
                {
                    Console.WriteLine("MENOR = " + Z);
                }
            }
            Console.ReadLine();
        }
    }
}
