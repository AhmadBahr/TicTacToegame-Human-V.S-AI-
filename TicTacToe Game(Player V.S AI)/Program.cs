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
    static bool CheckWinner(char symbol)
    {
        for(int i = 0; i <3; i++) 
        {
            if (board[i,0] == symbol && board[i,1] == symbol && board[i ,2 ] == symbol)
                return true;
            if (board[0,1] == symbol && board [1,i] == symbol && board[2 ,i] == symbol)
                return true;
        }

        if (board[0,0] == symbol && board[1,1] == symbol && board[2,2] == symbol)
            return true;
        if (board[0,2] == symbol && board[1 ,1] == symbol && board[2 , 0] == symbol)
            return true;

        return false;
    }
       static bool IsBoardFull()
    {
        for(int i = 0;i < 3;i++)
        {
            for(int j = 0;j < 3;j++)
            {
                if (board[i, j] == '_')
                    return false;
            }
        }
        return true;
    }
       static void PleyerMove()
    {
        int position;
        while (true) 
        {
            Console.WriteLine("Player's turn - Enter position( 1 -9):");
            if(int.TryParse(Console.ReadLine(), out position) && position >=1 && position <= 9) 
            {
                int row = (position - 1) / 3;
                int col = (position - 1) / 3;

                if (board[row, col] == '_')
                {
                    if (board[row , col] == '_')
                    {
                        board[row, col] = playerSymbol;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid move. The position is already taken. Try again");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
                }
            }
        
            static void CPUMove()
            {

            }
        {
            
        }
    }
    }
}

