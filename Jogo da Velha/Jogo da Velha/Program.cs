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

            int index = 1;

            int tentativas = 0;

            // Alimentando a Matriz.
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = index.ToString();
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

            string jogada = Console.ReadLine();

            Console.Clear();

            // Começa o jogo.
            while (tentativas < 9)
            {
                // Substituir o valor na sua respectiva casa.
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        if (matriz[i, j] == jogada)
                        {
                            matriz[i, j] = turno;
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

                jogada = Console.ReadLine();

                if (turno == "X")
                {
                    turno = "O";
                }
                else
                {
                    turno = "X";
                }

                tentativas++;

                Console.Clear();
            }

            Console.ReadLine();
        }
    }
}
