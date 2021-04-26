using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Velha
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matriz = new string[3, 3];
            string turno = "X";

            List<string> indexNumeros = new List<string> {};

            int index = 1;

            int tentativas = 1;

            Console.WriteLine("-------------------");
            Console.WriteLine("   JOGO DA VELHA   ");
            Console.WriteLine("-------------------");

            // Alimentando a Matriz.
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = index.ToString();
                    indexNumeros.Add(index.ToString());
                    index++;
                }
            }

            // Imprimir a matriz.
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($" [{matriz[i, j]}] ");
                }
                Console.WriteLine();
            }

            Console.Write($"\nVocê quer jogar [{turno}] em qual posição? ");
            string jogada = Console.ReadLine();

            Console.Clear();

            // Começa o jogo.
            while (tentativas < 9)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("   JOGO DA VELHA   ");
                Console.WriteLine("-------------------");

                // Substituir o valor na sua respectiva casa.
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        if (matriz[i, j] == jogada && indexNumeros.Contains(jogada))
                        {
                            matriz[i, j] = turno;
                            indexNumeros.Remove(jogada);
                        }
                    }
                }

                // Imprimir a matriz.
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        Console.Write($" [{matriz[i, j]}] ");
                    }
                    Console.WriteLine();
                }

                // Condição de vitória nas Diagonais.
                if (matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2] ||
                    matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0])
                {
                    Console.WriteLine("\n--------------");
                    Console.WriteLine("Fim de Jogo!!!");
                    Console.WriteLine("--------------");
                    Console.WriteLine($"\nParabéns!!! O ganhador é [{turno}].");
                    break;
                }
                // Condição de vitória nas Linhas.
                if (matriz[0, 0] == matriz[0, 1] && matriz[0, 1] == matriz[0, 2] ||
                    matriz[1, 0] == matriz[1, 1] && matriz[1, 1] == matriz[1, 2] ||
                    matriz[2, 0] == matriz[2, 1] && matriz[2, 1] == matriz[2, 2])
                {
                    Console.WriteLine("\n--------------");
                    Console.WriteLine("Fim de Jogo!!!");
                    Console.WriteLine("--------------");
                    Console.WriteLine($"\nParabéns!!! O ganhador é [{turno}].");
                    break;
                }
                // Condição de vitória nas Colunas.
                if (matriz[0, 0] == matriz[1, 0] && matriz[1, 0] == matriz[2, 0] ||
                    matriz[0, 1] == matriz[1, 1] && matriz[1, 1] == matriz[2, 1] ||
                    matriz[0, 2] == matriz[1, 2] && matriz[1, 2] == matriz[2, 2])
                {
                    Console.WriteLine("\n--------------");
                    Console.WriteLine("Fim de Jogo!!!");
                    Console.WriteLine("--------------");
                    Console.WriteLine($"\nParabéns!!! O ganhador é [{turno}].");
                    break;
                }

                if (turno == "X")
                {
                    turno = "O";
                }
                else
                {
                    turno = "X";
                }

                Console.WriteLine();
                Console.Write($"Você quer jogar [{turno}] em qual posição? ");
                jogada = Console.ReadLine();

                while (!indexNumeros.Contains(jogada))
                {
                    Console.WriteLine();
                    Console.Write("Jogada invalida. Tente Novamente: ");
                    jogada = Console.ReadLine();
                }

                tentativas++;

                Console.Clear();
            }
            if (tentativas == 9)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("   JOGO DA VELHA   ");
                Console.WriteLine("-------------------");

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        Console.Write($" [{matriz[i, j]}] ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\n--------------");
                Console.WriteLine("Fim de Jogo!!!");
                Console.WriteLine("--------------");
                Console.WriteLine($"\nQue triste!!! Ninguém ganhou.");
            }

            Console.ReadLine();
        }
    }
}
