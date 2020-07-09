using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};

		/// <summary>
		/// Displays the board to the user(s), this is called in the Play method in  the Game class
		/// </summary>
		public void DisplayBoard()
		{
			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine("     |     |");
				Console.WriteLine("  " + GameBoard[i, 0] + "  |  " + GameBoard[i, 1] + "  |  " + GameBoard[i, 2]);
				Console.WriteLine("     |     |");
				if (i < 2)
				{
					Console.WriteLine("-----------------");
				}
			}
		}
	}
}
