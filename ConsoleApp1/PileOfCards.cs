using System;
using System.Collections.Generic;

namespace Challenge1
{
    public class PileOfCards : ICardCollection, IPileOfCards
    {
        private List<Card> pileOfCards = new List<Card>();
        public void Add(Card card)
        {
            pileOfCards.Add(card);
        }

        public void AddMany(IEnumerable<Card> card)
        {
            pileOfCards.AddRange(card);
        }

        public Card CardAtPosition(int fromTop)
        {
            if (pileOfCards.Count > fromTop)
            {
                return pileOfCards[pileOfCards.Count - fromTop - 1];
            }

            return null;
        }

        public IEnumerable<Card> List()
        {
            return pileOfCards;
        }

        public Card Remove(int index)
        {
            Card cardAtIndex = pileOfCards[index];
            pileOfCards.RemoveAt(index);
            return cardAtIndex;
        }

        public Card TopCard()
        {
            int count = pileOfCards.Count;
            if (count > 0)
            {
                return pileOfCards[count - 1];
            }

            return null;
        }
    }
}
