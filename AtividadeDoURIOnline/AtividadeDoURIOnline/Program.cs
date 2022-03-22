using System;
using System.Globalization;

namespace uri1011
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double Raio, volume;
           


            Raio = double.Parse(Console.ReadLine());
            volume = 4.0 / 3.0 * 3.14159 * Raio * Raio * Raio;
            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));


            Console.ReadLine();
           
          
        }
    }
}