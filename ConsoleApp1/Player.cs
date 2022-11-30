using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class Player
    {
        private string name;
        public HandOfCards Hand { get; set; }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public Player(string name)
        {
            this.name = name;
            Hand = new HandOfCards();
        }

        public void ReceiveCard(Card card)
        {
            Hand.Add(card);
        }

        public Card PlayCard(int index = 0)
        {
            return Hand.Remove(index);
        }

        public void LookAtCards()
        {
            Console.Write($"{name} : ");

            foreach (var card in Hand.List())
            {
                Console.Write(card);
            }
            Console.WriteLine();
        }

        public void CollectCards(PileOfCards discardPile)
        {
            Hand.AddMany(discardPile.List());
            discardPile.Clear();
        }
    }
}
