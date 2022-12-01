using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge1.Players;

namespace Challenge1.Game
{
    public class BlackJackGame : IGame
    {
        private Player dealer;
        private Player player;
        private PackOfCards deck;
        public BlackJackGame()
        {
            dealer = new Player("Dealer");
            player = new Player("Player");
            deck = new PackOfCards();
        }
        public void Start()
        {
            Console.WriteLine("Welcome to Blackjack! \n");
            Console.WriteLine("Setting up game \n");
            deck.Shuffle();
            Console.WriteLine("Deck has been shuffled \n");
            dealer.InitializeHand(2, deck);
            player.InitializeHand(2, deck);
            Console.WriteLine("Hands have been dealt");
            Console.WriteLine();
            dealer.ShowHand();
            Console.WriteLine();
            player.ShowHand();
            Console.WriteLine("\n");
            Turns();
            DetermineWinner();
        }

        public void Turns()
        {
            Console.WriteLine("-------------");
            Console.WriteLine("Players Turn");
            Console.WriteLine("-------------");
            TakeTurn(player);
            Console.WriteLine();
            Console.WriteLine("-------------");
            Console.WriteLine("Dealer Turn");
            Console.WriteLine("-------------");
            TakeTurn(dealer);
            Console.WriteLine();
            Console.WriteLine("-------------");
            Console.WriteLine("Determine Results");
            Console.WriteLine("-------------");
        }

        public void TakeTurn(Player turnPlayer)
        {
            int turnPlayerScore = turnPlayer.GetScore();
            while (turnPlayerScore < 17)
            {
                Console.WriteLine("\n"+turnPlayer.name + " hits!");
                turnPlayer.AddCard(deck);
                turnPlayer.ShowHand();
                turnPlayerScore = turnPlayer.GetScore();
            }

            Console.WriteLine("\n"+turnPlayer.name + " stands!");
        }

        public void DetermineWinner()
        {
            int dealerScore = dealer.GetScore();
            int playerScore = player.GetScore();
            dealer.SetGameOver();
            Console.WriteLine("Final Hand:");
            dealer.ShowHand();
            Console.WriteLine();
            player.ShowHand();
            Console.WriteLine("\n");
            Console.WriteLine("Final Score: ");
            player.DisplayScore();
            dealer.DisplayScore();

            if (playerScore > 21)
            {
                Console.WriteLine("Player's total is greater than 21! Dealer wins!");
            }
            else if (playerScore > dealerScore || dealerScore > 21)
            {
                Console.WriteLine("Player has a higher score than dealer! Player wins!");
            }
            else if (dealerScore > playerScore && dealerScore <= 21)
            {
                Console.WriteLine("Dealer score is greater than player score! Dealer wins!");
            }
            else if (dealerScore == playerScore)
            {
                Console.WriteLine("Player and dealer have the same score! Game is a draw!");
            }
        }
    }
}
