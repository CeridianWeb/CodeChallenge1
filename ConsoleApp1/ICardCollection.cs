using System.Collections.Generic;

namespace Challenge1
{
    public interface ICardCollection
    {
        void Add(Card card);

        void AddMany(IEnumerable<Card> card);

        Card Remove(int index);

        IEnumerable<Card> List();
    }
}