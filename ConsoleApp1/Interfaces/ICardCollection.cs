using Challenge1.Interfaces;
using System.Collections.Generic;

namespace Challenge1
{
    public interface ICardCollection
    {
        void Add(ICard card);

        void AddMany(IEnumerable<ICard> card);

        void RemoveByIndex(int index);

        void Remove(ICard card);

        IEnumerable<ICard> List();
    }
}
