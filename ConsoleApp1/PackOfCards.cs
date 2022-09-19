using Challenge1.Helpers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge1
{
    /// <summary>
    /// Simulates a deck of 52 playing cards.           
    /// </summary>
    public class PackOfCards
    {
        private readonly List<Card> cards = new List<Card>();

        /// <summary>
        /// Initializes a full deck of cards.
        /// </summary>
        public PackOfCards() => CreateFullDeckOfCards();

        /// <summary>
        /// Takes the card at the top of the pack and returns it to the caller and removes it from the pack of cards.
        /// </summary>
        /// <example>This shows the intended usage. <code>var cardFromTop = pack.Deal()</code></example>
        /// <returns>An instance of the <see cref="Card"/> class.</returns>
        public Card Deal()
        {
            var card = cards.FirstOrDefault();
            cards.Remove(card);
            return card;
        }

        /// <summary>
        /// Returns the number of cards in the pack currently. <see cref="Deal"/> will decrement this number.  />
        /// </summary>
        public int CardsRemaining => cards.Count();

        /// <summary>
        /// Fills a deck with 52 cards.
        /// </summary>
        private void CreateFullDeckOfCards()
        {
            if (cards.Count() < 52)
            {
                for (int i = 0; i < 52; i++)
                {                    
                    var cardNumber = ConvertToCardValue(i % 13 + 1);
                    var suit = (Suits)Math.Floor(Convert.ToDouble(i / 13));
                    var card = new Card(cardNumber, suit);

                    cards.Add(card);
                }
            }
        }

        /// <summary>
        /// Converts the calculated card number to a string containing a number or face value.
        /// </summary>
        private string ConvertToCardValue(double value)
        {
            var stringValue = "";
            switch (value)
            {
                case 1:
                    stringValue = "A";
                    break;
                case 11:
                    stringValue = "J";
                    break;
                case 12:
                    stringValue = "Q";
                    break;
                case 13:
                    stringValue = "K";
                    break;
                default:
                    stringValue = value.ToString();
                    break;
            }
            return stringValue;
        }
    }
}