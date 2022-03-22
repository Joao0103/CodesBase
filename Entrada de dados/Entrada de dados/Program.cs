using System;
using System.Globalization;

namespace Entrada_de_dados {
    class Program {
        static void Main(string[] args) {

            string nome = Console.ReadLine();
            int quartos = int.Parse(Console.ReadLine());
            double produtos = double.Parse(Console.ReadLine());

            
            string[] vet = Console.ReadLine().Split(' ');
            nome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu nome completo: ");
            Console.WriteLine(nome);
            Console.WriteLine("Quantos quartos tem na sua casa: ");
            Console.WriteLine(quartos);
            Console.WriteLine("Entre com o preço de um produto: ");
            Console.WriteLine(produtos.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Entre com seu ultimo nome, idade e altura (na mesma linha): ");
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            

            Console.ReadLine();
            



        }
    }
}
