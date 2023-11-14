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
        Console.WriteLine("Welcome to Tic-Tac-Toe!");
        PrintBoard();

        while (true)
        {
            PlayerMove();
            PrintBoard();
            Clear.Console();

            if (CheckWinner(playerSymbol))
            {
                Console.WriteLine("Player wins!");
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
                Console.WriteLine("CPU wins!");
                break;
            }

            if (IsBoardFull())
            {
                Console.WriteLine("It's a tie!");
                break;
            }
        }
    }

    static void PrintBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static bool CheckWinner(char symbol)
    {
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == symbol && board[i, 1] == symbol && board[i, 2] == symbol)
                return true;
            if (board[0, i] == symbol && board[1, i] == symbol && board[2, i] == symbol)
                return true;
        }
        if (board[0, 0] == symbol && board[1, 1] == symbol && board[2, 2] == symbol)
            return true;
        if (board[0, 2] == symbol && board[1, 1] == symbol && board[2, 0] == symbol)
            return true;

        return false;
    }

    static bool IsBoardFull()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i, j] == '_')
                    return false;
            }
        }
        return true;
    }

    static void PlayerMove()
    {
        int position;
        while (true)
        {
            Console.WriteLine("Player's turn - Enter position (1-9): ");
            if (int.TryParse(Console.ReadLine(), out position) && position >= 1 && position <= 9)
            {
                int index = position - 1;
                int row = index / 3;
                int col = index % 3;

                if (board[row, col] == '_')
                {
                    board[row, col] = playerSymbol;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid move. The position is already taken. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
            }
        }
    }

    static void CPUMove()
    {
        int position;
        while (true)
        {
            Console.WriteLine("CPU's turn - Enter position (1-9): ");
            position = new Random().Next(1, 10);
            int index = position - 1;
            int row = index / 3;
            int col = index % 3;

            if (board[row, col] == '_')
            {
                board[row, col] = cpuSymbol;
                break;
            }
        }
    }
}
