using Challenge1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    public class HandOfCards : ICardCollection
    {
        private List<ICard> hand = new List<ICard>();

        /// <summary>
        /// Adds a single card to the current hand.
        /// </summary>
        public void Add(ICard card) => hand.Add(card);

        /// <summary>
        /// Retrieves the current hand of cards. 
        /// </summary>
        public IEnumerable<ICard> List() => hand;

        /// <summary>
        /// Removes a specific card from the current hand.
        /// </summary>
        public void Remove(ICard card) => hand.Remove(card);

        /// <summary>
        /// Removes a specific card, by index, from the current hand.
        /// </summary>
        public void RemoveByIndex(int index) => hand.RemoveAt(index);

        /// <summary>
        /// Adds multiple cards to the current hand.
        /// </summary>
        public void AddMany(IEnumerable<ICard> cards)
        {
            foreach (var card in cards)
            {
                hand.Add(card);
            }
        }
    }
}
