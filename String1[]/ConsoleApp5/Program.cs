using System;

namespace ConsoleApp5 {
    class Program {
        static void Main(string[] args) {


            string[] V = Console.ReadLine().Split(' ');
            int HoraInicial = int.Parse(V[0]);
            int FinalJogo = int.Parse(V[1]);

            int Duracao;
            if (HoraInicial < FinalJogo) {
                Duracao = FinalJogo - HoraInicial;
            }
            else {
                Duracao = 24 - HoraInicial + FinalJogo;
            }
            Console.WriteLine("O JOGO DUROU: " + Duracao + " HORA(S)");

            Console.ReadLine();
        }
        
    }
}
