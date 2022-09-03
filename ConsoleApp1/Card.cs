using Humanizer;
using System;

namespace Challenge1
{
    /// <summary>
    /// Simulates a card from a pack of cards. 
    /// Should have a Suit - Hearts, Clubs, Dimonds or Spades
    /// Should have a Rank - A 2-10 J Q K. 
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Represents the suit of the card
        /// </summary>
        public Suit Suit { get; set; }
        /// <summary>
        /// Represents the Rank of the card
        /// </summary>
        public Rank Rank { get; set; }
        /// <summary>
        /// If true uses longer names for <see cref="ToString"/>.
        /// </summary>
        /// <example>King of Hearts -- KH</example>
        public bool ShortName { get; set; }
        public Card(Suit suit, Rank rank)
        {
            this.Suit = suit;
            this.Rank = rank;
            ShortName = true;
        }

        /// <summary>
        /// Overridden to provide the name of the card. Uses <see cref="ShortName"/> to determine the format of the output.
        /// </summary>
        /// <example> KH or King of Hearts </example>
        /// <returns>Suit and rank of the card represented.</returns>
        public override string ToString()
        {
            if (ShortName)
            {
                return this.Rank.Humanize() + this.Suit.Humanize();
            }
            else
            {
                return this.Rank + " of " + this.Suit;
            }
        }
    }
}