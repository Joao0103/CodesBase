using System.Globalization;
using System;

namespace ConsoleApp9 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Dados da primeira pessoa:");

            string nome1, nome2;
            int idade1, idade2;

            Console.Write("Nome: ");
            nome1 = Console.ReadLine();

            Console.Write("Idade: ");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");

            Console.Write("Nome: ");
            nome2 = Console.ReadLine();

            Console.Write("Idade: ");
            idade2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (idade1 > idade2) {
                Console.WriteLine("Pessoa mais velha: " + nome1);
            }
            else {
                Console.WriteLine("Pessoa mais velha: " + nome2);
            }
            Console.WriteLine();

            double soma = (idade1 + idade2) / 2.0;

            Console.WriteLine("Diferença: " + soma.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
