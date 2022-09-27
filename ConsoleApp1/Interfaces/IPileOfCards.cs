using Challenge1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    public interface IPileOfCards
    {
        ICard CardAtPosition(int fromTop);
        ICard TopCard();
    }
}
