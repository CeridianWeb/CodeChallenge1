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
       // private string face;
        private string suit;
        private string rank;

        public Card( string cardSuit, string cardRank)
        {
           // face = cardFace;
            suit = cardSuit;
            rank = cardRank;
        }

        public override string ToString()
        {
            return rank + suit;
        }
    }
}