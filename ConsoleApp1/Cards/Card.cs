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

        public Card(string suit, string value)
        {
            this.suit = suit;
            this.rank = Enum.TryParse(value, out Ranks rank) ? rank.ToString() : value;
        }

        public override string ToString()
        {
            return suit[0] + rank;
        }
    }
}