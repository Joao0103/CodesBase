using System;
using System.Globalization;

namespace Media3_URI_1040 {
    class Program {
        static void Main(string[] args) {

            int codigo1, peca1, codigo2, peca2;
            double valor1, valor2;
            

            string[] vet = Console.ReadLine().Split(' ');
            codigo1 = int.Parse(vet[0]);
            peca1 = int.Parse(vet[1]);
            valor1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            codigo2 = int.Parse(vet[0]);
            peca2 = int.Parse(vet[1]);
            valor2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double soma = valor1 + valor2;
            soma = soma;

            if (peca1 == peca2) {
                Console.Write("VALOR A PAGAR:  R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));
            }
            else {
                Console.Write("VALOR A PAGAR:  R$ " + soma.ToString("F2", CultureInfo.InvariantCulture) + peca2 * peca1);
                }

            Console.ReadLine();

        }
    }
}
