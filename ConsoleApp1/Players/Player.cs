using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.Players
{
    public class Player:IPlayer
    {
        private HandOfCards hand;
        private int currentSum;
        public string name;
        private bool isGameOver;

        public Player(string name)
        {
            hand = new HandOfCards();
            currentSum = 0;
            this.name = name;
            isGameOver = false;
        }

        public void InitializeHand(int numOfCards, PackOfCards deck)
        {
            for (int i = 0; i < numOfCards; i++)
            {
                AddCard(deck);
            }
        }

        public void AddCard(PackOfCards deck)
        {
            Card card = deck.Deal();
            hand.Add(card);

            if (card.rank == "Ace")
            {
                if (currentSum <= 10)
                {
                    currentSum += 11;
                }
                else
                {
                    currentSum += 1;
                }
            }else if (card.rank == "Jack" || card.rank == "Queen" || card.rank == "King")
            {
                currentSum += 10;
            }
            else
            {
                currentSum += Int32.Parse(card.rank);
            }
        }

        public void ShowHand()
        {
            var cardList = hand.List();
            Console.Write(name + " cards in hand are: ");
            if (name == "Dealer" && isGameOver == false)
            {
                foreach (var card in cardList)
                {
                    if (card == cardList.FirstOrDefault())
                    {
                        Console.Write("Secret, ");
                        continue;
                    }
                    Console.Write(card + ", ");
                }
            }
            else
            {
                foreach (var card in cardList)
                {
                    Console.Write(card + ", ");
                }
            }
        }

        public int GetScore()
        {
            return currentSum;
        }

        public void DisplayScore()
        {
            Console.WriteLine(name + " score is " + currentSum);
        }

        public void SetGameOver()
        {
            isGameOver = true;
        }
    }
}
