using System;

namespace ConsoleApp6 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
          
            }

            Console.ReadLine();





        }
    }
}
