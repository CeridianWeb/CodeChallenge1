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
        private IList<Card> deck = new List<Card>();
        public PackOfCards()
        {
            for(int i =1; i<= sizeof(Suits); i++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    Card card = new Card(((Suits)i).ToString(),
                        Enum.TryParse(value.ToString(), out Ranks rank) ? rank.ToString() : value.ToString());

                    deck.Add(card);
                }
            }
        }
        /// <summary>
        /// Takes the card at the top of the pack and returns it to the caller and removes it from the pack of cards.
        /// </summary>
        /// <example>This shows the intended usage. <code>var cardFromTop = pack.Deal()</code></example>
        /// <returns>An instance of the <see cref="Card"/> class.</returns>
        public Card Deal()
        {
            Card card = deck[deck.Count - 1];
            deck.RemoveAt(deck.Count-1);
            return card;
        }

        /// <summary>
        /// Returns the number of cards in the pack currently. <see cref="Deal"/> will decrement this number.  />
        /// </summary>
        public int CardsRemaining
        {
            get => deck.Count;
        }

        public void Shuffle()
        {
            deck = deck.OrderBy(card => Guid.NewGuid()).ToList();
        }
    }
}