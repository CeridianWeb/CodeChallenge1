using System.Collections.Generic;

namespace Challenge1
{
    public class PileOfCards
    {
        private Stack<Card> cards;

        public PileOfCards()
        {
            cards = new Stack<Card>();
        }

        public void Add(Card card)
        {
            cards.Push(card);
        }
        public Card Remove(int index)
        {
            return cards.Pop();
        }

        public Card TopCard()
        {
            return cards.Peek();
        }
        public Card CardAtPosition(int fromTop)
        {
            return cards.ToArray()[fromTop - 1];
        }

        public IEnumerable<Card> List()
        {
            return cards;
        }

        public void Clear()
        {
            cards.Clear();
        }
    }
}