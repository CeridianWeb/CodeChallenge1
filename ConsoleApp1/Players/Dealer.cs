//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Challenge1.Players
//{
//    public class Dealer:IPlayer
//    {
//        private HandOfCards hand;
//        private int currentSum;

//        public Dealer()
//        {
//            currentSum = 0;
//            hand = new HandOfCards();
//        }

//        public void InitializeHand(int numOfCards, PackOfCards deck)
//        {
//            for (int i = 0; i < numOfCards; i++)
//            {
//                hand.Add(deck.Deal());
//            }
//        }

//        public void AddCard(PackOfCards deck)
//        {
//            Card card = deck.Deal();
//            hand.Add(card);

//            if (card.rank == "Ace")
//            {
//                if (currentSum <= 10)
//                {
//                    currentSum += 11;
//                }
//                else
//                {
//                    currentSum += 1;
//                }
//            }
//            else if (card.rank == "Jack" || card.rank == "Queen" || card.rank == "King")
//            {
//                currentSum += 10;
//            }
//            else
//            {
//                currentSum += Int32.Parse(card.rank);
//            }
//        }

//        public void ShowHand()
//        {
//            hand.ShowHand();
//        }


//        public void GetScore()
//        {
//            Console.WriteLine("Dealer score is "+currentSum);
//        }
//    }
//}
