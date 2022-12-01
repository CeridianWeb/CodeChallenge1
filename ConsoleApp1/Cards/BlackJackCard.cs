using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.Cards
{
    public class BlackJackCard : ICard
    {
        public string suit;
        public string rank;
        public int gameValue;
        public BlackJackCard(string suit, string value)
        {
            this.suit = suit;
            this.rank = Enum.TryParse(value, out Ranks rank) ? rank.ToString() : value;
            this.gameValue = int.Parse(value) > 10 ? 10 : int.Parse(value);
        }

        public int GetGameValue()
        {
            return gameValue;
        }
    }
}
