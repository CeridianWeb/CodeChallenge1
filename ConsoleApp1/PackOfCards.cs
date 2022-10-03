using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge1
{
    /// <summary>
    /// Simulates a deck of 52 playing cards
    /// </summary>
    public class PackOfCards : IPackOfCards
    {
        private Queue<Card> cards;
        private Random random;

        public PackOfCards()
        {
            cards = new Queue<Card>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    var card = new Card(suit, rank);
                    cards.Enqueue(card);
                }
            }

            random = new Random();
        }

        /// <summary>
        /// Takes the card at the top of the pack and returns it to the caller and removes it from the pack of cards.
        /// </summary>
        /// <example>This shows the intended usage. <code>var cardFromTop = pack.Deal()</code></example>
        /// <returns>An instance of the <see cref="ICard"/> interface.</returns>
        public ICard Deal()
        {
            if (cards.Count > 0)
            {
                return cards.Dequeue();
            }
            return null;
        }

        /// <summary>
        /// Returns the number of cards in the pack currently. <see cref="Deal"/> will decrement this number.
        /// </summary>
        public int CardsRemaining
        {
            get { return cards.Count; }
        }

        public void Shuffle()
        {
            int n = cards.Count;
            var cardList = cards.ToList();

            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card buffered = cardList[k];
                cardList[k] = cardList[n];
                cardList[n] = buffered;
            }
            cards = new Queue<Card>(cardList);
        }
    }
}