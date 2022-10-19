using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge1
{
    /// <summary>
    /// Simulates a deck of 52 playing cards            
    /// </summary>
     class PackOfCards : Card
    {

        const int NUM_OF_CARDS = 52; // total number of cards
        private Card[] deck; // array of all playing cards

        public PackOfCards()
        {
            deck = new Card[NUM_OF_CARDS];
        }
        public Card[] getDeck { get { return deck; } } // getting the current deck

        //create deck of 52 cards which will be 13values each with 4 suits 13x4=52
        public void setupDeck()
        {
            int i = 0;
            foreach(SUIT s in Enum.GetValues(typeof(SUIT)))
            {
                foreach(VALUE v in Enum.GetValues(typeof(VALUE)))
                {
                    deck[i] = new Card { MySuit = s, MyValue = v };
                    i++;
                }
            }
            ShuffleCards();
        }
        //ShuffleDeck
        public void ShuffleCards()
        {
            Random rand = new Random();
            Card temp;

            //run the shuffle 1000times
            //randomizing as much as possible
            for (int shuffleTimes = 0; shuffleTimes < 1000; shuffleTimes++)
            {
                for(int i = 0; i < NUM_OF_CARDS; i++)
                {
                    //swap the cards randomly
                    int secondCardIndex = rand.Next(13);
                    temp = deck[i];
                    deck[i] = deck[secondCardIndex];
                    deck[secondCardIndex] = temp;
                }
            }
        }

    }
}