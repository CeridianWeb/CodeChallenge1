using Challenge1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    public class PileOfCards : ICardCollection, IPileOfCards
    { 
        //if this will only be used as a "discard" pile, a stack could be used to implement a true first in last out concept.
        //In that case, CardAtPosition(), RemoveByIndex(), and List() would not be required/utilized
        //A method to remove the entire pile may be useful
        //Remove() can be refactored to simply Pop() (no card or index required)

        //Ignoring the above comments, multiple PileOfCards could be utilized in a game such as solitaire

        private LinkedList<ICard> pile = new LinkedList<ICard>();

        /// <summary>
        /// Adds a single card to the current pile.
        /// </summary>
        public void Add(ICard card) => pile.AddFirst(card);

        /// <summary>
        /// Utilizes Linq to return the card in the pile at a specific index. 
        /// </summary>
        public ICard CardAtPosition(int fromTop) => pile.ElementAt(fromTop);

        /// <summary>
        /// Returns the current pile of cards. 
        /// </summary>
        public IEnumerable<ICard> List() => pile.ToList();

        /// <summary>
        /// Removes a specific card object. (O(1) removal efficiency).
        /// </summary>
        public void Remove(ICard card) => pile.Remove(card);

        /// <summary>
        /// Removes a specific card by index. (O(n) removal efficiency).
        /// </summary>
        public void RemoveByIndex(int index) => pile.Remove(pile.ElementAt(index));

        /// <summary>
        /// Retrieves the first card at the top of the pile.
        /// </summary>
        public ICard TopCard() => pile.First();

        /// <summary>
        /// Adds multiple cards to the current pile.  
        /// </summary>
        public void AddMany(IEnumerable<ICard> cards)
        {
            foreach (var card in cards)
            {
                pile.AddFirst(card);
            }
        }

        //public void RemoveByIndex(int index)
        //{
        //    var current = pile.First();
        //    for (int i = 0; i <= index; i++)
        //    {
        //        if (i != index)
        //        {
        //            current = current.Next;
        //            continue;
        //        }
        //        pile.Remove(current);
        //    }
        //}
    }
}
