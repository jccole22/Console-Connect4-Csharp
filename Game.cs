using System;
using System.Collections.Generic;


public class Connect4Game 
{
    //properties
    char p1 {get;}
    char p2 {get;}
    char currentPlayer;
    char[,] board;


    //constructor
    public Connect4Game (char startingPlayer = 'X')
    {
        p1 = 'X';
        p2 = 'O';
        currentPlayer = startingPlayer;
        board = new char [6,7];
    }

    //methods


    // Makes play by inserting player char into next open row in desired column
    // input: column number, player char
    // output: void
    public void MakePlay(int col, char player)
    {
        //fill 'bottom' of the array first like in actual game
        for (int i = board.GetLength(0) -1; i >= 0; i--)
        {
            // \0 is default c# char value
            if (board[i,col] == '\0')
            {
                board[i,col] = player;
                break;
            }
        }
    }


    // NOTE: MIGHT BE USELESS SINCE PLAYER CHAR IS GIVEN TO MakePlay()
    // Switches current player
    // input: none
    // output: void
    public void SwitchPlayer()
    {
        if (currentPlayer == 'X')
        {
            currentPlayer = 'O';
        }
        else
        {
            currentPlayer = 'X';
        }
    }


    // Prints current state of the board to console
    // input: none
    // output: void
    public void PrintBoard() 
    {
        //traverse rows
        for (int i = 0; i <board.GetLength(0); i++)
        {
            //traverse columns
            for (int j = 0; j < board.GetLength(1); j++)
            {
                Console.Write($"|{board[i,j]}");
            }
            Console.Write("|\n");
        }
        Console.WriteLine("---------------");
        Console.WriteLine(" 1 2 3 4 5 6 7");
    }
}