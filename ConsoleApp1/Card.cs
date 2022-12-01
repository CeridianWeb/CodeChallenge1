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
        public string suit;
        public string rank;

        public Card(string suit, string rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        public override string ToString()
        {
            return suit[0] + rank;
        }
    }
}