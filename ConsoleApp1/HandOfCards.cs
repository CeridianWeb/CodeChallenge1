using System;
using System.Collections.Generic;

namespace Challenge1
{
    public class HandOfCards : ICardCollection
    {
        public void Add(Card card)
        {
            throw new NotImplementedException();
        }

        public void AddMany(IEnumerable<Card> card)
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
    }
}
