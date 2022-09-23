using Challenge1.Helpers.Enums;
using System;

namespace Challenge1
{
    /// <summary>
    /// Simulates a card from a pack of cards. 
    /// Should have a Suit - Hearts, Clubs, Dimonds or Spades
    /// Should have a Rank - A 2-10 J Q K. 
    /// </summary>
    public class Card
    {
        public string CardNumber { get; set; }
        public Suits Suit { get; set; }

        public Card(string CardNumber, Suits Suit)
        {
            this.CardNumber = CardNumber;
            this.Suit = Suit;
        }

        public override string ToString()
        {
            return CardNumber + Suit.ToString().Substring(0, 1);
        }
    }
}