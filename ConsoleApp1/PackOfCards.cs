using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge1
{
    /// <summary>
    /// Simulates a deck of 52 playing cards            
    /// </summary>
    public class PackOfCards
    {

        private  Card[] packofcards;
        private int currentCard;
        private const int NUMBER_OF_CARDS = 52;

        public PackOfCards()
        {
            string[] faces = { "Aces", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
            string[] rank = { "A", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            packofcards = new Card[NUMBER_OF_CARDS];
            currentCard = 0;
            for (int count = 0; count < packofcards.Length; count++)
                packofcards[count] = new Card(faces[count % 11], suits[count / 13]);
        }

        /// <summary>
        /// Takes the card at the top of the pack and returns it to the caller and removes it from the pack of cards.
        /// </summary>
        /// <example>This shows the intended usage. <code>var cardFromTop = pack.Deal()</code></example>
        /// <returns>An instance of the <see cref="Card"/> class.</returns>
        /// 

        public Card Deal()
        {
            // throw new NotImplementedException();

            if (currentCard - 1 < packofcards.Length)
                return packofcards[currentCard++];
            else
                return null;
        }


        /// <summary>
        /// Returns the number of cards in the pack currently. <see cref="Deal"/> will decrement this number.  />
        /// </summary>
        public int CardsRemaining => NUMBER_OF_CARDS - currentCard;

    }
}