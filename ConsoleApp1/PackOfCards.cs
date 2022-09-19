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

        private Card[] deck;
        private int currentCard = 0;
        
        private const int NUM_OF_CARD = 52; 


        public PackOfCards()
        {
            
            string[] suits = {"Club", "Diamond","Heart","Spades"};

            deck = new Card[NUM_OF_CARD];

            for(int count=0;count <deck.Length; count++)
            {

                deck[count] = new Card(count%13+1, suits[count / 13]);
            }
        }

        public Card Deal()
        {
            

            if (currentCard - 1 < deck.Length)
            {        
                return deck[currentCard++];
            } else
            {
                return null;
            }
        }

        /// <summary>
        /// Returns the number of cards in the pack currently. <see cref="Deal"/> will decrement this number.  />
        /// </summary>
        public int CardsRemaining => NUM_OF_CARD - currentCard;

        
    }
}