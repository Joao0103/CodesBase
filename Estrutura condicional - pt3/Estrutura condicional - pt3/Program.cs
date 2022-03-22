using System;
using System.Globalization;

namespace Estrutura_condicional___pt3 {
    class Program {
        static void Main(string[] args) {
            int HorasTrabalhada, Numero;
            double Salario, ValorHora;

            Numero =int.Parse(Console.ReadLine());
            HorasTrabalhada = int.Parse(Console.ReadLine());
            ValorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           

            Salario = HorasTrabalhada * ValorHora;

            Console.WriteLine("NUMBER = " + Numero);
            Console.WriteLine("SALARY = U$ " + Salario.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();


        }
    }
}
