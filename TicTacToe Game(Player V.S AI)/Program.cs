using System;
using System.Security.Cryptography;

class TicTacToe
{
    static char[,] board =  {
        { '_', '_', '_' },
        { '_', '_', '_' },
        { '_', '_', '_' } };

    static char playerSymbol = 'X';
    static char cpuSymbol = 'O';

    static void Main()
    {
        Console.WriteLine("Welcome to a game of Tic-Tac-Toe!");
        PrintBoard();

        while (true)
        {
            PlayerMove();
            PrintBoard();

            if (CheckWinner(playerSymbol))
            {
                Console.WriteLine("Player Wins!");
                break;
            }

            if (IsBoardFull())
            {
                Console.WriteLine("It's a tie!");
                break;
            }

            CPUMove();
            Console.WriteLine("CPU's move:");
            PrintBoard();

            if (CheckWinner(cpuSymbol))
            {
                Console.WriteLine("CPU's Wins!:");
                break;
            }

            {
                if (IsBoardFull())
                {
                    Console.WriteLine("It's a Tie");
                    break;
                }
            }

        }
    }

    static void PrintBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(board[i, j] + "");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    }
};
