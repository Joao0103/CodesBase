using System;

namespace Estrutura_consiciional___pt2 {
    class Program {
        static void Main(string[] args) {
            int A, B, C, D, DIFERENCA;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            DIFERENCA = (A * B - C * D);

            Console.WriteLine("DIFERENCA = " + DIFERENCA);

            Console.ReadLine();

        }
    }
}
