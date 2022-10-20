﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class DrawCards
    {
        //Draw Card Outlines
        public static void DrawCardOutline (int xcoor, int ycoor)
        {
            //giving console colors
            Console.ForegroundColor = ConsoleColor.White;

            int x = xcoor * 12; // draw 12 spaces of cards
            int y = ycoor; // height, not needed to determine the height

            //draw top left corner of each card
            Console.SetCursorPosition(x, y);
            //offesetting width with 12 spaces
            Console.Write(" ________\n"); //top edge of the card
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(x, y + 1 + i); // as i increases, the space will move to the right
                //draw 5 card in a row and one in each line
                if (i != 9)
                    Console.WriteLine("|__________|"); // left and right edges of the card
                else
                    Console.WriteLine("|__________|"); //bottom edge of the card

            }

        }
        //Displays suit and value of the card inside its outline
        public static void DrawCardSuitValue(Card card, int xcoor, int ycoor)
        {
            char cardSuit = ' ';
            int x = xcoor * 12;
            int y = ycoor;
            //Encode each byte array from the CodePage437 into a character
            //hearts and diamonds are red, clubs and spades are black
            switch(card.MySuit)
            {
                case Card.SUIT.HEARTS:
                    cardSuit = Encoding.GetEncoding(437).GetChars(new byte[] { 3 })[0];
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Card.SUIT.DIAMONDS:
                    cardSuit = Encoding.GetEncoding(437).GetChars(new byte[] { 4 })[0];
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Card.SUIT.CLUBS:
                    cardSuit = Encoding.GetEncoding(437).GetChars(new byte[] { 5 })[0];
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case Card.SUIT.SPADES:
                    cardSuit = Encoding.GetEncoding(437).GetChars(new byte[] { 6 })[0];
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }
            //display the encoded character and card value
            Console.SetCursorPosition(x +5, y +5);
            Console.Write(cardSuit);
            Console.SetCursorPosition(x + 4, y + 7);
            Console.Write(card.MyValue);
        }
    }
}