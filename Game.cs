using System;
using System.Text;


public class Connect4Game 
{
    //properties
    char p1 {get;}
    char p2 {get;}
    public char currentPlayer {get; set;}
    char[,] board;
    int numplays;


    //constructor
    public Connect4Game (char startingPlayer = 'X')
    {
        p1 = 'X';
        p2 = 'O';
        currentPlayer = startingPlayer;
        numplays = 0;
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
                numplays++;
                break;
            }
        }
    }


    // Checks to make sure game isnt a draw (over 42 plays)
    // input: none
    // output: boolean - true if not over, false if over 42 and game is a draw
    public bool CheckNumPlays()
    {
        if (numplays < 42)
        {
            return true;
        }
        return false;
    }


    // Checks if there is an open spot in the selected column
    // input: column number
    // output: boolean - true if there is space, false if none
    public bool CheckColumn (int col)
    {
        if (board[0,col] == '\0')
        {
            return true;
        }
        return false;
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

    
    // Creates string representation of the current state of the game board
    // input: none
    // output: string version of board
    public string BoardToString()
    {
        StringBuilder boardString = new StringBuilder();

        //traverse rows
        for (int i = 0; i <board.GetLength(0); i++)
        {
            //traverse columns
            for (int j = 0; j < board.GetLength(1); j++)
            {
                boardString.Append($"|{board[i,j]}");
            }
            boardString.Append("|\n");
        }
        boardString.Append("---------------\n");
        boardString.Append(" 1 2 3 4 5 6 7");

        return boardString.ToString();
    }



    // METHODS FOR CHECKING FOR WIN. Incredibly expensive with current 
    // implementation. In future change to only checking win condition
    // on current piece played. This impl re-checks the whole entire board
    // each time its called.

    // calls all helper methods to check for win
    // input: player char
    // output: boolean
    public bool CheckWin(char player)
    {
        if (this.CheckVertical(player) || this.CheckHorizontal(player) || this.CheckDiagonal(player))
        {
            return true;
        }
        return false;
    }

    // checks if there is a vertical win
    // input: player char
    // output: boolean
    public bool CheckVertical(char player)
    {
        for(int i = 0; i < board.GetLength(0)-3; i++) {
			for(int j = 0; j < board.GetLength(1);j++) {
				if(board[i,j] == player &&
						board[i+1,j] == player &&
						board[i+2,j] == player &&
						board[i+3,j] == player) {
					return true;
				}
			}
		}
        return false;
    }

    // checks if there is a horizontal win
    // input: player char
    // output: boolean
    public bool CheckHorizontal(char player)
    {
        for(int i = 0; i < board.GetLength(0); i++) {
			for(int j = 0; j < board.GetLength(1)-3;j++) {
				if(board[i,j] == player &&
						board[i,j+1] == player &&
						board[i,j+2] == player &&
						board[i,j+3] == player) {
					return true;
				}
			}
		}
        return false;
    }

    // checks if there is a diagonal win
    // input: player char
    // output: boolean
    public bool CheckDiagonal(char player)
    {
        for(int i = 3; i < board.GetLength(0); i++) {
			for(int j = 0; j < board.GetLength(1)-3;j++) {
				if(board[i,j] == player &&
						board[i-1,j+1] == player &&
						board[i-2,j+2] == player &&
						board[i-3,j+3] == player) {
					return true;
				}
			}
		}
        for(int i = 0; i < board.GetLength(0)-3; i++) {
			for(int j = 0; j < board.GetLength(1)-3;j++) {
				if(board[i,j] == player &&
						board[i+1,j+1] == player &&
						board[i+2,j+2] == player &&
						board[i+3,j+3] == player) {
					return true;
				}
			}
		}
        return false;
    }
}