using Challenge1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    public class Blackjack
    {
        private IPackOfCards deck = new PackOfCards();
        private ICardCollection dealersHand = new HandOfCards();
        private ICardCollection p1Hand = new HandOfCards();

        public Blackjack() => InitializeGame();

        /// <summary>
        /// Initializes the game.
        /// </summary>
        public void InitializeGame()
        {
            deck.Shuffle();
            dealersHand = GenerateHand();
            p1Hand = GenerateHand();

            Console.WriteLine("+++++++++++++++++++++++");
            Console.WriteLine("++++++ Blackjack ++++++");
            Console.WriteLine("+++++++++++++++++++++++");
            Console.WriteLine();
            ShowHands(false);
            if(InitialCheck())
            {
                return;
            }
            Console.WriteLine("=======================");

            PlayerInteraction();
        }

        /// <summary>
        /// Allows the player and dealer game interactions.
        /// </summary>
        public void PlayerInteraction()
        {
            //player plays
            Console.WriteLine();
            Console.WriteLine("Players turn");
            Console.WriteLine("=======================");
            PlayerLogic();

            //dealer plays
            Console.WriteLine();
            Console.WriteLine("Dealers turn");
            Console.WriteLine("=======================");
            DealerLogic();

            //endgame
            Console.WriteLine();
            Console.WriteLine("Outcome");
            Console.WriteLine("=======================");
            Outcome();
        }

        /// <summary>
        /// The logic used by the player during their turn.
        /// </summary>
        public void PlayerLogic()
        {
            var dealersDraw = CardConversion(ViewDealersDraw(dealersHand));
            var playersHand = GetCardTotal(p1Hand);
            while (playersHand < 17)
            {
                if (Enumerable.Range(2, 6).Contains(dealersDraw) && Enumerable.Range(13, 16).Contains(playersHand))
                {
                    Console.WriteLine("Player Stands");
                    break;
                }
                else if (Enumerable.Range(4, 6).Contains(dealersDraw) && playersHand == 12)
                {
                    Console.WriteLine("Player Stands");
                    break;
                }
                else
                {
                    HitHand(p1Hand);
                    playersHand = GetCardTotal(p1Hand);
                    Console.WriteLine("Player Hit");
                    ShowHands(false);
                }
            }
            if (playersHand >= 17)
            {
                Console.WriteLine("Player Stands");
            }
        }

        /// <summary>
        /// The logic used by the dealer after the player has taken their turn.
        /// </summary>
        public void DealerLogic()
        {
            while (GetCardTotal(dealersHand) <= 16)
            {
                HitHand(dealersHand);
                Console.WriteLine("Dealer Hit");
                ShowHands(false);
            }

            if (GetCardTotal(dealersHand) >= 17)
            {
                Console.WriteLine("Dealer Stands");
            }
        }

        /// <summary>
        /// Outputs the hand totals and calculates the winner of the game.
        /// </summary>
        public void Outcome()
        {
            var playerTotal = GetCardTotal(p1Hand);
            var dealerTotal = GetCardTotal(dealersHand);

            Console.WriteLine("Ending Hands");
            ShowHands(true);
            Console.WriteLine("Dealer total: {0}", dealerTotal);
            Console.WriteLine("Player total: {0}", playerTotal);
            Console.WriteLine();

            if (playerTotal > 21)
            {
                Console.WriteLine("Hand total exceeds 21. Dealer wins.");
            }
            else if (dealerTotal <= 21 && dealerTotal > playerTotal)
            {
                Console.WriteLine("Dealer is closer to 21. Dealer wins.");
            }
            else if (dealerTotal > 21 || dealerTotal < playerTotal)
            {
                Console.WriteLine("Player is closer to 21. Player wins.");
            }
            else if (dealerTotal == playerTotal)
            {
                Console.WriteLine("Player and Dealer tied. Draw.");
            }
        }

        /// <summary>
        /// Used to generate a hand containing 2 cards.
        /// </summary>
        /// <returns>An instance of the <see cref="ICardCollection"/> class.</returns>
        public ICardCollection GenerateHand()
        {
            var hand = new HandOfCards();
            for (var i = 0; i < 2; i++)
            {
                hand.Add(deck.Deal());
            }
            return hand;
        }

        /// <summary>
        /// Used to output the card values in each players hands.
        /// </summary>
        /// <param name="isEnd">Displays the dealer's hole card if true</param>
        public void ShowHands(bool isEnd)
        {
            var holeCard = isEnd ? dealersHand.List().FirstOrDefault().ToString() : "??"; //the first card of the dealer should only be known after play

            //show dealers hand
            var dealerHand = "     Dealers Hand = ";
            foreach (var card in dealersHand.List())
            {
                if (card == dealersHand.List().FirstOrDefault())
                {
                    dealerHand += holeCard + " | ";
                    continue;
                }
                dealerHand += card + " | ";
            }
            Console.WriteLine(dealerHand);

            //show players hand
            var playerHand = "     Players Hand = ";
            foreach (var card in p1Hand.List())
            {
                playerHand += card + " | ";
            }
            Console.WriteLine(playerHand);
        }

        /// <summary>
        /// Used to check if the game is over after the initial deal. Outputs a corresponding message if true.
        /// </summary>
        /// <returns>True if the game is over.</returns>
        public bool InitialCheck()
        {
            if (GetCardTotal(p1Hand) == 21)
            {
                if (GetCardTotal(dealersHand) == 21)
                {
                    Console.WriteLine("Player and Dealer both dealt 21. Draw");
                }
                Console.WriteLine("Player was dealt 21. Player wins.");
                return true;
            }
            return false;
        }

        /// <summary>
        /// Used to get a running total of a players hand.
        /// </summary>
        /// <param name="hand">The <see cref="ICardCollection"/> to calculate</param>
        /// <returns>An integer value containg the hand total.</returns>
        public int GetCardTotal(ICardCollection hand)
        {
            var total = 0;
            foreach (var card in hand.List())
            {
                if (CardConversion(card) == 1 && total <= 10)
                {
                    total += 11; //ace high
                } else
                {
                    total += CardConversion(card);
                }
            }
            return total;
        }

        /// <summary>
        /// Used to assign a number value to a face card.
        /// </summary>
        /// <param name="card">The <see cref="ICard"/> to calculate</param>
        /// <returns>An integer containing the value of the passed <see cref="ICard"/>.</returns>
        public int CardConversion(ICard card)
        {
            var cardValue = 0;
            if (Int32.TryParse(card.CardNumber, out int value))
            {
                cardValue = value;
            } else
            {
                if (card.CardNumber == "A")
                {
                    cardValue = 1;
                } else
                {
                    cardValue = 10;
                }
            }
            return cardValue;
        }

        /// <summary>
        /// Used when the player needs to draw a new card from the deck.
        /// </summary>
        /// <param name="hand">The <see cref="ICardCollection"/> to add a new card to</param>
        public void HitHand(ICardCollection hand) => hand.Add(deck.Deal());

        /// <summary>
        /// Used to get the dealer's draw card.
        /// </summary>
        /// <param name="dealersHand">The dealers hand</param>
        /// <returns>An <see cref="ICard"/> corresponding to the dealer's last dealt card.</returns>
        public ICard ViewDealersDraw(ICardCollection dealersHand) => dealersHand.List().LastOrDefault();
    }
}
