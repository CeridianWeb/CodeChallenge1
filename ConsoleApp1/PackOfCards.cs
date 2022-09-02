using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge1
{
    /// <summary>
    /// Simulates a deck of 52 playing cards            
    /// </summary>
    public class PackOfCards
    {
        /// <summary>
        /// Takes the card at the top of the pack and returns it to the caller and removes it from the pack of cards.
        /// </summary>
        /// <example>This shows the intended usage. <code>var cardFromTop = pack.Deal()</code></example>
        /// <returns>An instance of the <see cref="Card"/> class.</returns>
        public Card Deal()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the number of cards in the pack currently. <see cref="Deal"/> will decrement this number.  />
        /// </summary>
        public int CardsRemaining
        {
            get { throw new NotImplementedException(); }
        }
    }
}