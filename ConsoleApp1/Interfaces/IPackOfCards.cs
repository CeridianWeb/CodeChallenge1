using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.Interfaces
{
    public interface IPackOfCards
    {
        int CardsRemaining { get; }
        ICard Deal();
        void Shuffle();
    }
}
