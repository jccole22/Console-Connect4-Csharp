using System;





Connect4Game game = new Connect4Game();



bool gameOver = false;
int input;

while (gameOver == false)
{
    Console.WriteLine($"Player-{game.currentPlayer} please enter column number:");

    input = Convert.ToInt32(Console.ReadLine());

    if (game.CheckColumn(input-1))
    {
        game.MakePlay(input-1, game.currentPlayer);

        Console.WriteLine(game.BoardToString());

        if (game.CheckWin(game.currentPlayer))
        {
            Console.WriteLine($"Player-{game.currentPlayer} wins!");
            break;
        }

        if (game.CheckNumPlays() == false)
        {
            Console.WriteLine("Game has ended in a draw!");
            break;
        }

        game.SwitchPlayer();
    }
    else 
    {
        Console.WriteLine("That column is full!");
    }

    

}







// Console.WriteLine("Please choose an option\n1. Start game \n2. Exit");

// //Input verification (gotta be cleaner way to do it)
// //will only accept 1 or 2 
// bool correctInput = false;
// while (correctInput == false) 
// {
//     try
//     {
//         var input = Convert.ToInt32(Console.ReadLine());
//         if (input == 1) 
//         {
//             Console.WriteLine("Starting game...");
//             correctInput = true;
//         } 
//         else if (input == 2) 
//         {
//             Console.WriteLine("Exiting...");
//             correctInput = true;
//         }
//         else 
//         {
//             Console.WriteLine("Input must be 1 or 2");
//         }       
//     } 
//     catch (FormatException)
//     {
//     Console.WriteLine("Input must be a number");
//     }

// }






