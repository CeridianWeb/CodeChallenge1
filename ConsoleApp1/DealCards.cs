using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class DealCards : PackOfCards
    {
        private Card[] playerHand;
        private Card[] computerHand;
        private Card[] sortedPlayerHand;
        private Card[] sortedComputerHand;

        public DealCards()
        {
            playerHand = new Card[5];
            sortedPlayerHand = new Card[5];
            computerHand = new Card[5];
            sortedComputerHand = new Card[5];
        }
        public void Deal()
        {
            setupDeck(); // Create deck of cards and shuffle shuffle shuffle shuffle
            getHand();
            sortCards();
            displayCards();
            evaluateHands();
        }
        public void getHand()
        {
            //5 cards for player
            for (int i = 0; i < 5; i++)
                playerHand[i] = getDeck[i];
            // 5 cards for computer for next 5 cards
            for (int i = 5; i < 10; i++)
            computerHand[i -5] = getDeck[i];
        }

        public void sortCards()
        {
            var queryPlayer = from hand in playerHand
                              orderby hand.MyValue
                              select hand;
            var queryComputer = from hand in computerHand
                                orderby hand.MyValue
                                select hand;
            var index = 0;
            foreach(var element in queryPlayer.ToList())
            {
                sortedPlayerHand[index] = element;
                index++;
            }

            index = 0;
            foreach (var element in queryComputer.ToList())
            {
                sortedComputerHand[index] = element;
                index++;
            }

        }
        public void displayCards()
        {
           Console.Clear(); 
           int x = 0; //position of the cursor. Moving it to left and right
           int y = 1; // y position of the cursor, moving up and down

            //player hand
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Player's Hand");
            for (int i = 0; i < 5; i++)
            {
                DrawCards.DrawCardOutline(x, y);
                DrawCards.DrawCardSuitValue(sortedPlayerHand[i], x, y);
                x++;
            }
            y = 15; //move the row of computer cards below the player's cards
            x = 0; // reset the x position
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int i = 5; i < 10; i++)
            {
                DrawCards.DrawCardOutline(x, y);
                DrawCards.DrawCardSuitValue(sortedComputerHand[i-5], x, y);
                x++; //move to the right
            }

        }
        public void evaluateHands()
        {

        }
    }
}
