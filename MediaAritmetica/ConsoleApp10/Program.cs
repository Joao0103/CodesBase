using System;
using System.Globalization;

namespace MediaAritmetica {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Dados do primeiro funcionário: ");

            string Nome1, Nome2;
            double Salario1, Salario2;

            Console.Write("Nome: ");
            Nome1 = Console.ReadLine();

            Console.Write("Sálario: ");
            Salario1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");

            Console.Write("Nome: ");
            Nome2 = Console.ReadLine();

            Console.Write("Sálario: ");
            Salario2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (Salario1 + Salario2) / 2.0;

            Console.WriteLine("Sálario médio: " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }

    }
}

