using System;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            StartGame();
            
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            Classes.Player P1 = new Classes.Player();
            Classes.Player P2 = new Classes.Player();
            Classes.Game game = new Classes.Game(P1, P2);
        }


    }
}
