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
        /// <summary>
        /// Takes the card at the top of the pack and returns it to the caller and removes it from the pack of cards.
        /// </summary>
        /// <example>This shows the intended usage. <code>var cardFromTop = pack.Deal()</code></example>
        /// <returns>An instance of the <see cref="Card"/> class.</returns>
        /// 
        private Card[] packofcards;
        private int currentCard;
        private const int NUMBER_OF_CARDS = 52;
        private Random randomNumber;

        public PackOfCards()
        {
            string[] faces = { "Aces", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
            packofcards = new Card[NUMBER_OF_CARDS];
            currentCard = 0;
            randomNumber = new Random();
            for (int count = 0; count < packofcards.Length; count++)
                packofcards[count] = new Card(faces[count % 11], suits[count / 13]);
        }
        public Card Deal()
        {
            // throw new NotImplementedException();

            if (currentCard < packofcards.Length)
                return packofcards[currentCard++];
            else
                return null;
        }


        /// <summary>
        /// Returns the number of cards in the pack currently. <see cref="Deal"/> will decrement this number.  />
        /// </summary>
        public int CardsRemaining
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}