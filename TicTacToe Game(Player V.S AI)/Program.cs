using System;

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
    }
};
