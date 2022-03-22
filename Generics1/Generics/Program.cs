using Generics.Entities;
using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService printService = new PrintService();
            Console.Write("How many values? ");
            int N = int.Parse(Console.ReadLine());

            for(int i=0; i<N; i++)
            {
                int X = int.Parse(Console.ReadLine());
                printService.AddValue(X);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());
            Console.ReadLine();
        }

    }
}
