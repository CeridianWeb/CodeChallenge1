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
        private int cardNumber;
        private string suit;


        public  Card (int cardFace, string cardSuite)
        {
            cardNumber = cardFace;
            suit = cardSuite;

        }

        public override string ToString()
        {
            return cardNumber + suit;
        }
    }
}