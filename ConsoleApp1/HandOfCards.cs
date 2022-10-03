using System.Collections.Generic;

namespace Challenge1
{
    class HandOfCards
    {
        private List<Card> cards;

        public HandOfCards()
        {
            cards= new List<Card>();
        }

        public void Add(Card card)
        {
            cards.Add(card);
        }

        public void AddMany(IEnumerable<Card> card)
        {
            cards.AddRange(card);
        }

        public Card Remove(int index)
        {
            Card card = cards[index];
            cards.RemoveAt(index);
            return card;
        }

        public IEnumerable<Card> List()
        {
            return cards;
        }
    }
}