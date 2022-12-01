using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.Players
{
    public interface IPlayer
    {
        void InitializeHand(int numOfCards, PackOfCards deck);
        void AddCard(PackOfCards deck);
        void ShowHand();
        int GetScore();
        void DisplayScore();
    }
}
