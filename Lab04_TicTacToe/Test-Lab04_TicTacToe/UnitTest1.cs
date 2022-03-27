using System;
using Xunit;
using Lab04_TicTacToe;
using Lab04_TicTacToe.Classes;


namespace Test_Lab04_TicTacToe
{
    public class UnitTest1
    {
        Player player1 = new Player();
        Player player2 = new Player();

        [Fact]
        public void TestAGameBoard()
        {
            Game newGame = new Game(player1, player2);
            Board newBoard = new Board();
            newBoard.GameBoard = new string[,]
            {
                {"O", "X", "3"},
                {"4", "X", "O"},
                {"7", "X", "9"},
            };
            newGame.Board = newBoard;
            Assert.True(newGame.CheckForWinner(newGame.Board));
        }

        [Fact]
        public void TestSwitchPlayer()
        {
            player1.IsTurn = true;
            player2.IsTurn = false;

            Game newGame = new Game(player1, player2);

            Assert.True(newGame.PlayerOne.IsTurn);
            Assert.False(newGame.PlayerTwo.IsTurn);
            
            newGame.SwitchPlayer();
            
            Assert.False(newGame.PlayerOne.IsTurn);
            Assert.True(newGame.PlayerTwo.IsTurn);
        }
        [Fact]
        public void TestPosition()
        {
            Position position = new Position(0, 0);
        }

        [Fact]
        public void TestADraw()
        {
            Game newGame = new Game(player1, player2);
            Board newBoard = new Board();
            newBoard.GameBoard = new string[,]
            {
                {"O", "X", "O"},
                {"X", "X", "O"},
                {"X", "O", "X"},
            };
            newGame.Board = newBoard;
            Assert.False(newGame.CheckForWinner(newGame.Board));
        }
    }
}
