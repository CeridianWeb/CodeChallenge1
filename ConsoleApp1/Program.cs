using System;
using System.Text;

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

    /// <summary>
    /// Runs the main program loop and provides the entry point
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Do not change this, code must run as it is here.
            var pack = new PackOfCards();
            Console.WriteLine( "Number of cards = {0}", pack.CardsRemaining);
            while (pack.CardsRemaining > 0)
            {
                Card card = pack.Deal();
                Console.WriteLine(card);
            }
            Console.ReadLine();
        }
    }
}





















//private static readonly Random rnd = new Random();

//var discardPile = new PileOfCards();
//var players = new List<Player>() {
//    new Player("Dave"),
//    new Player("Paul"),
//    new Player("Fred"),
//    new Player("Ann") };

//var board = new Board(10, 10);
//board.Draw();


// Snap
//var dealTurn = 0;
//while (pack.CardsRemaining > 0)
//{
//    var index = dealTurn % players.Count();
//    var currentDealPlayer = players[index];
//    currentDealPlayer.ReceiveCard(pack.Deal());
//    dealTurn++;
//}

//var playerTurn = 0;

//// Game Loop
//while (players.Count > 1)
//{
//    var index = playerTurn % players.Count();
//    var currentPlayer = players[index];
//    if (!currentPlayer.Hand.List().Any())
//    {
//        players.Remove(currentPlayer);
//        Console.WriteLine($"{currentPlayer.Name} cant play");
//        continue;
//    }

//    discardPile.Add(currentPlayer.PlayCard(0));

//    // Both players Check for snap
//    Console.WriteLine($"{currentPlayer.Name} : {discardPile.TopCard()}");

//    if (discardPile.List().Count() > 1 && discardPile.TopCard().Rank == discardPile.CardAtPosition(1).Rank)
//    {
//        Console.WriteLine("------Snap-----");
//        Console.WriteLine(currentPlayer.Name + " wins Snap");
//        currentPlayer.CollectCards(discardPile);

//    }

//    playerTurn++;
//}

//Console.WriteLine($"winner is {players[0].Name}");

//Console.WriteLine("Pile");

//foreach (var card in discardPile.List())
//{
//    Console.WriteLine(card);
//}

