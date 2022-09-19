using System;
using System.Collections.Generic;

namespace Challenge1
{
    public class PileOfCards : ICardCollection, IPileOfCards
    {
        public void Add(Card card)
        {
            throw new NotImplementedException();
        }

        public void AddMany(IEnumerable<Card> card)
        {
            throw new NotImplementedException();
        }

        public Card CardAtPosition(int fromTop)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Card> List()
        {
            throw new NotImplementedException();
        }

        public Card Remove(int index)
        {
            throw new NotImplementedException();
        }

        public Card TopCard()
        {
            throw new NotImplementedException();
        }
    }
}
