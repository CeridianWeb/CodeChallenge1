using Humanizer;

namespace Challenge1
{
    /// <summary>
    /// Simulates a card from a pack of cards.
    /// Should have a Suit - Hearts, Clubs, Dimonds or Spades
    /// Should have a Rank - A 2-10 J Q K.
    /// </summary>
    public class Card : ICard
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
        /// If true uses longer names for <see cref="ToString" />.
        /// </summary>
        /// <value>
        ///   <c>true</c> if <see cref="ShortName" />; otherwise, <c>false</c>.
        /// </value>
        /// <example>King of Hearts -- KH</example>
        public bool ShortName { get; set; }


        public Card(Suit suit, Rank rank, bool shortName = true)
        {
            this.Suit = suit;
            this.Rank = rank;
            ShortName = shortName;
        }

        /// <summary>
        /// Overridden to provide the name of the card. Uses <see cref="ShortName" /> to determine the format of the output.
        /// </summary>
        /// <returns>
        /// Suit and rank of the card represented.
        /// </returns>
        /// <example> <code>KH</code> or <code>King of Hearts</code> </example>
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