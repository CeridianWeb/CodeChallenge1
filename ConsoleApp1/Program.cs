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

    class Program
    {
        static void Main(string[] args)
        {
            // Do not change this, code must run as it is here.
            var pack = new PackOfCards();
            pack.Shuffle();
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