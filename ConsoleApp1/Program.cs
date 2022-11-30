using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Challenge1
{
    // Simulate a pack of cards
    // 52 cards in a pack
    // Suits Harts Club Diamond Spade - This order is important
    // Ace 2 - 10 Jack Queen King
    // Ace is low = 1
    //
    // Card should be able to write its own value i.e. 3H, JD etc
    // PackOfCards should create the cards it needs for a full 52 card deck
    // and be able to Deal() a single card at a time.

    /// <summary>Runs the main program loop and provides the entry point</summary>
    internal class Program
    {
#pragma warning disable IDE0060 // Remove unused parameter

        private static void Main(string[] args)
#pragma warning restore IDE0060 // Remove unused parameter
        {

            // Init
            var playerTurn = 0;
            var dealTurn = 0;
            var rnd = new Random();
            var discardPile = new PileOfCards();
            var pack = new PackOfCards();
            pack.Shuffle(); // Dont forget to Shuffle
            // Create Players 
            var players = new List<Player>() {
                new Player("Dave"),
                new Player("Paul"),
                new Player("Fred"),
                new Player("John"),
                new Player("Mike"),
                new Player("Rob"),
                new Player("Ann") };

            // Deal
            while (pack.CardsRemaining > 0)
            {
                var index = dealTurn % players.Count();
                var currentDealPlayer = players[index];
                currentDealPlayer.ReceiveCard(pack.Deal());
                dealTurn++;
            }

            // Game Loop
            while (players.Count > 1)
            {
                var index = playerTurn % players.Count();
                var currentPlayer = players[index];
                if (!currentPlayer.Hand.List().Any())
                {
                    Console.WriteLine($"{currentPlayer.Name} cant play");
                    Thread.Sleep(500);
                    playerTurn++;
                    continue;
                }

                discardPile.Add(currentPlayer.PlayCard());

                // All players Check for snap
                Console.WriteLine($"{currentPlayer.Name} : {discardPile.TopCard()}");

                // Check for Snap
                if (discardPile.List().Count() > 1 && discardPile.TopCard().Rank == discardPile.CardAtPosition(2).Rank)
                {
                    //Snap trigered
                    Console.WriteLine("------Snap-----");
                    Console.WriteLine("Two " + discardPile.TopCard().Rank + "s ");

                    // Determine Snap Winner
                    var randomplayer = rnd.Next(0, players.Count() - 1);
                    var snapwinner = players[randomplayer];
                    Console.WriteLine(snapwinner.Name + " wins Snap");
                    snapwinner.CollectCards(discardPile);

                    //remove out players
                    var outPlayers = players.Where(p => !p.Hand.List().Any()).ToList();
                    outPlayers.ForEach(p =>
                    {
                        Console.WriteLine(p.Name + " is out!!");
                        players.Remove(p);
                    });
                }
                Thread.Sleep(500);
                playerTurn++;
            }

            Console.WriteLine($"winner is {players[0].Name}");

            Console.WriteLine("Pile");

            foreach (var card in discardPile.List())
            {
                Console.WriteLine(card);
            }

            Console.ReadLine();
        }
    }
}