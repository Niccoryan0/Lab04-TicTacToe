using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Player
    {
		public string Name { get; set; }
		/// <summary>
		/// P1 is X and P2 will be O
		/// </summary>
		public string Marker { get; set; }

		/// <summary>
		/// Flag to determine if it is the user's turn
		/// </summary>
		public bool IsTurn { get; set; }

		/// <summary>
		/// Prompts the player for a position on the board and calls PositionForNumber to convert it to a row and column. It is called in the TakeTurn method.
		/// </summary>
		/// <param name="board">The current game board</param>
		/// <returns>Coordinate (in the form of row and column)</returns>
		public Position GetPosition(Board board)
		{
			Position desiredCoordinate = null;
			while (desiredCoordinate is null)
			{
				Console.WriteLine("Please select a location");
				Int32.TryParse(Console.ReadLine(), out int position);
				desiredCoordinate = PositionForNumber(position);
			}
			return desiredCoordinate;
		}

		/// <summary>
		/// Takes in a numerical value and converts it to corresponding game board position. It is called in the GetPosition method and the CheckForWinner method in the Game class.
		/// </summary>
		/// <param name="position">Numeric value from 1 to 9 representing a position on the game board</param>
		/// <returns>The Position object that represents the numeric value passed in, or null if the position is not an integer from 1 to 9.</returns>
		public static Position PositionForNumber(int position)
		{
			switch (position)
			{
				case 1: return new Position(0, 0); // Top Left
				case 2: return new Position(0, 1); // Top Middle
				case 3: return new Position(0, 2); // Top Right
				case 4: return new Position(1, 0); // Middle Left
				case 5: return new Position(1, 1); // Middle Middle
				case 6: return new Position(1, 2); // Middle Right
				case 7: return new Position(2, 0); // Bottom Left
				case 8: return new Position(2, 1); // Bottom Middle 
				case 9: return new Position(2, 2); // Bottom Right

				default: return null;
			}
		}


        /// <summary>
        /// Handles users taking turns, calls the GetPosition method to get their choice of location, and replaces the position with their marker if it is not already used. It is called in the Play method in the Game class.
        /// </summary>
        /// <param name="board">Current game board</param>
        public void TakeTurn(Board board)
		{
			IsTurn = true;

			Console.WriteLine($"{Name} it is your turn");

			Position position = GetPosition(board);

			//TODO: Fix the bug.
			while(!Int32.TryParse(board.GameBoard[position.Row, position.Column], out int _))
            {
				Console.WriteLine("This space is already occupied");
				position = GetPosition(board);
			}
			board.GameBoard[position.Row, position.Column] = Marker;
		}
	}
}
