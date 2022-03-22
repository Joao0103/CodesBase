using System;

namespace uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());

            if (m == 0 || m == 45 || m == 360)
            {
                Console.WriteLine("Bom Dia!!");
            }
            if (m == 90)
            {
                Console.WriteLine("Boa Tarde!!");
            }
            if (m == 180)
            {
                Console.WriteLine("Boa Noite!!");
            }
            else
            {
                Console.WriteLine("De Madrugada!!");
            }
            Console.ReadLine();
        }
    }
}