using System;

namespace go_fish
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to Greenlake!");
            PlayGoFish newGame = new PlayGoFish();
            newGame.Play();
            // System.Console.WriteLine(newGame.p1.name);
            // System.Console.WriteLine(newGame.p3.name);
            // System.Console.WriteLine(newGame.gameDeck.deal().stringVal);
        }
    }
}
