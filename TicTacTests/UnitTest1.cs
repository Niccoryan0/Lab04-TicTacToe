using Lab04_TicTacToe.Classes;
using Xunit;

namespace TicTacTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindHorizontalWinner()
        {
            //ARRANGE
            Board board = new Board();
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            game.Board = board;
            // ACT
            board.GameBoard[0, 0] = "X";
            board.GameBoard[0, 1] = "X";
            board.GameBoard[0, 2] = "X";
            // ASSERT
            bool answer = game.CheckForWinner(board);
            Assert.True(answer);
        }

        [Fact]
        public void CanFindVerticalWinner()
        {
            //ARRANGE
            Board board = new Board();
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            game.Board = board;
            // ACT
            board.GameBoard[0, 0] = "X";
            board.GameBoard[1, 0] = "X";
            board.GameBoard[2, 0] = "X";
            // ASSERT
            bool result = game.CheckForWinner(board);
            Assert.True(result);
        }

        [Fact]
        public void CanFindDiagWinner()
        {
            //ARRANGE
            Board board = new Board();
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            game.Board = board;
            // ACT
            board.GameBoard[0, 0] = "O";
            board.GameBoard[1, 1] = "O";
            board.GameBoard[2, 2] = "O";
            // ASSERT
            bool result = game.CheckForWinner(board);
            Assert.True(result);
        }

        [Fact]
        public void CanFindReverseDiagWinner()
        {
            //ARRANGE
            Board board = new Board();
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            game.Board = board;
            // ACT
            board.GameBoard[0, 2] = "X";
            board.GameBoard[1, 1] = "X";
            board.GameBoard[2, 0] = "X";
            // ASSERT
            bool result = game.CheckForWinner(board);
            Assert.True(result);
        }

        [Fact]
        public void CanReturnFalseIfNoWinner()
        {
            //ARRANGE
            Board board = new Board();
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            game.Board = board;
            // ACT
            board.GameBoard[0, 1] = "X";
            board.GameBoard[1, 1] = "X";
            board.GameBoard[2, 2] = "X";
            // ASSERT
            bool result = game.CheckForWinner(board);
            Assert.False(result);
        }


        [Fact]
        public void CanSwitchPlayersStartingTrue()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            p1.IsTurn = true;
            game.SwitchPlayer();
            Assert.False(p1.IsTurn);
        }

        [Fact]
        public void CanSwitchPlayersStartingFalse()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            p1.IsTurn = false;
            game.SwitchPlayer();
            Assert.True(p1.IsTurn);
        }

        [Fact]
        public void CanConvertNumsToCoordinates()
        {
            Position result = Player.PositionForNumber(5);
            Position expected = new Position(1, 1);
            Assert.Equal(expected, result);
        }


    }
}
