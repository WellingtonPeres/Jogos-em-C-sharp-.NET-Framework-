using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinhe_se_Poder
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int pontosJogador = 0;
            int pontosComputador = 0;

            for (int i = 0; i < 3; i++)
            {
                int aleatorio = rand.Next(5);
                //Console.WriteLine(aleatorio);// Temporario                 

                Console.WriteLine("Tente adivinhar um número entre 0 e 5:");
                int tentativa = int.Parse(Console.ReadLine());

                if (tentativa == aleatorio)
                {
                    pontosJogador += 1;
                    Console.WriteLine("Parabéns. Você acertou!!!");
                }
                else
                {
                    pontosComputador += 1;
                    Console.WriteLine("Que pena. Você errou!!!");
                }
            }
            Console.WriteLine("--------------------------------------------------");
            if (pontosJogador > pontosComputador)
            {
                Console.WriteLine($"Você ganhou. Você acertou {pontosJogador} vezes.");
            }
            else
            {
                Console.WriteLine($"Você perdeu. Você só acertou {pontosJogador} vezes.");
            }
            Console.WriteLine("--------------------------------------------------");

            Console.ReadLine();
        }
    }
}
