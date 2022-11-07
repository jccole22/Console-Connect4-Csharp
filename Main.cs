using System;


Connect4Game game = new Connect4Game();

Console.WriteLine(game.BoardToString());


bool gameOver = false;
int input;

while (gameOver == false)
{
    Console.WriteLine($"Player-{game.currentPlayer} please enter column number:");

    bool correctInput = false;
    while (correctInput == false) 
    {
        try
        {
            input = Convert.ToInt32(Console.ReadLine());
            if (input >= 1 && input <=7) 
            {
                if (game.CheckColumn(input-1))
                {
                    game.MakePlay(input-1, game.currentPlayer);

                    Console.WriteLine(game.BoardToString());

                    if (game.CheckWin(game.currentPlayer))
                    {
                        Console.WriteLine($"Player-{game.currentPlayer} wins!");
                        gameOver = true;
                        break;
                    }

                    if (game.CheckNumPlays() == false)
                    {
                        Console.WriteLine("Game has ended in a draw!");
                        gameOver = true;
                        break;
                    }

                    game.SwitchPlayer();
                }
                else 
                {
                    Console.WriteLine("That column is full!");
                }
                correctInput = true;
            }
            else
            {
                Console.WriteLine("Input must be between 1 and 7");
                Console.WriteLine($"Player-{game.currentPlayer} please enter column number:");
            }     
        } 
        catch (FormatException)
        {
        Console.WriteLine("Input must be a number");
        Console.WriteLine($"Player-{game.currentPlayer} please enter column number:");
        }

    }

    

}

