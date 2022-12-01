using System;
using System.Collections.Generic;

namespace Challenge1
{
    public class HandOfCards : ICardCollection
    {
        private List<Card> hand;

        public HandOfCards()
        {
            hand = new List<Card>();
        }
        public void Add(Card card)
        {
            hand.Add(card);
        }

        public void AddMany(IEnumerable<Card> card)
        {
            hand.AddRange(card);
        }

        public IEnumerable<Card> List()
        {
            return hand;
        }

        public Card Remove(int index)
        {
            Card card = hand[index];
            hand.RemoveAt(index);
            return card;
        }

        public void ShowHand()
        {
            foreach (var card in hand)
            {
                Console.Write(card +", ");
            }
        }
    }
}
