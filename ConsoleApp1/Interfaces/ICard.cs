using Challenge1.Helpers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.Interfaces
{
    public interface ICard
    {
        string CardNumber { get; set; }
        Suits Suit { get; set; }
        string ToString();
    }
}
