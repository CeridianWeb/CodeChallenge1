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
        private string face;
        private string suit;

        public Card(string cardFace, string cardSuit)
        {
            face = cardFace;
            suit = cardSuit;

        }

        public override string ToString()
        {
            return face + " of " + suit;
        }
    }
}