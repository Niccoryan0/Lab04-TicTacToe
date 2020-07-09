using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGame();
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            Console.WriteLine("Welcome to Tic Tac Toe:");
            // Get Names
            Console.WriteLine("Enter the name of Player 1:");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter the name of Player 2:");
            string name2 = Console.ReadLine();
            // Create Players
            Player player1 = new Player();
            Player player2 = new Player();
            // Assign Values
            player1.Name = name1;
            player1.Marker = "X";
            player2.Name = name2;
            player2.Marker = "O";
            // Play game instance
            Game game = new Game(player1, player2);
            Player winner = game.Play();
            if (winner == player1)
            {
                Console.WriteLine($"Great job {winner.Name}, you won!");
            }
            else if (winner == player2)
            {
                Console.WriteLine($"Great job {winner.Name}, you won!");
            }
            else
                Console.WriteLine("It\'s a tie! No winners this time.");
        }


    }
}
