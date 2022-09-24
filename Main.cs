using System;





Connect4Game game = new Connect4Game();

game.MakePlay(0, 'X');
game.MakePlay(0, 'O');
game.MakePlay(1, 'X');
game.MakePlay(1, 'O');
game.MakePlay(2, 'X');
game.MakePlay(2, 'O');
game.MakePlay(3, 'X');
game.MakePlay(3, 'O');
game.MakePlay(4, 'X');
game.MakePlay(4, 'O');
game.MakePlay(5, 'X');
game.MakePlay(5, 'O');
game.MakePlay(6, 'X');
game.MakePlay(6, 'O');
game.PrintBoard();








































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






