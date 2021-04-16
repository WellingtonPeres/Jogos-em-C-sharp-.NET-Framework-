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
            List<string> lista = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            string[,] matriz = new string[3, 3];
            string turno = "X";

            int tentativas = 1;
            int index = 1;         

            bool finalizarJogo = false;

            Console.WriteLine("---------------------------");
            Console.WriteLine("Bem vindo ao Jogo da Velha!");
            Console.WriteLine("---------------------------");
            Console.WriteLine();

            // Inicializa os valores.
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = index.ToString();
                    index += 1;
                }
            }

            // Imprime os valores.
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]} |");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Roda o jogo.
            while (tentativas <= 9)
            {
                Console.Write($"Vai jogar [{turno}] em qual posição? ");
                string jogada = Console.ReadLine();
                
                while (!lista.Contains(jogada))
                {
                    Console.WriteLine("Jogada invalida. Tente novamente: ");
                    jogada = Console.ReadLine();
                }
                lista.Remove(jogada);

                Console.Clear();

                tentativas += 1;

                Console.WriteLine("---------------------------");
                Console.WriteLine("Bem vindo ao Jogo da Velha!");
                Console.WriteLine("---------------------------");
                Console.WriteLine();

                // Subistituição dos valores.
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (matriz[i, j] == jogada)
                        {
                            matriz[i, j] = turno;
                        }
                        Console.Write($"{matriz[i, j]} |");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                // Condição de vitória Diagonais.
                if (matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2] ||
                    matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0])
                {
                    finalizarJogo = true;
                }
                // Condição de vitória Linhas.
                if (matriz[0, 0] == matriz[0, 1] && matriz[0, 1] == matriz[0, 2] ||
                    matriz[1, 0] == matriz[1, 1] && matriz[1, 1] == matriz[1, 2] ||
                    matriz[2, 0] == matriz[2, 1] && matriz[2, 1] == matriz[2, 2])
                {
                    finalizarJogo = true;
                }

                // Condição de vitória Colunas.
                if (matriz[0, 0] == matriz[1, 0] && matriz[1, 0] == matriz[2, 0] ||
                    matriz[0, 1] == matriz[1, 1] && matriz[1, 1] == matriz[2, 1] ||
                    matriz[0, 2] == matriz[1, 2] && matriz[1, 2] == matriz[2, 2])
                {
                    finalizarJogo = true;
                }

                if (finalizarJogo == true)
                {
                    Console.WriteLine("JOGO FINALIZADO !!!");
                    Console.WriteLine($"PARABÉNS !!! O ganhador do jogo foi: [ {turno} ].");
                    break;
                }

                // Auteração dos turnos.
                if (turno == "X")
                {
                    turno = "O";
                }
                else
                {
                    turno = "X";
                }

            }
            if (finalizarJogo == false)
            {
                Console.WriteLine("JOGO FINALIZADO !!!");
                Console.WriteLine("Que TRISTE !!! Não teve nenhum ganhador.");
            }
            Console.ReadLine();
        }
    }
}
