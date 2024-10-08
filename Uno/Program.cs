using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string player1Name, player2Name;
            do
            {
                //INTRO
                Console.WriteLine("Welcome To UNE©!");
                Console.WriteLine("Press any key to begin... ");
                input = Console.ReadLine();
                if (checkExit(input))
                    break;
                //Gets player Names
                Console.WriteLine("Player 1 enter your name!: ");
                player1Name = Console.ReadLine();
                Console.WriteLine("Player 2 enter your name!: ");
                player1Name = Console.ReadLine();

            }
            while (checkExit(input) == false);
        }
        //EXIT METHOD
        public static bool checkExit(string input)
        {
            if (string.Equals(input.ToLower(), "quit"))
                return true;
            return false;
        }
    }
    class Card
    {
        //type 0 = normal card; type 1 = special add card; type 2 = 
        private int type;
        private string color;
        private int value;

        public Card()
        {
            type = 0;
            color = "red";
            value = 0;
        }

    }

    class Deck
    {
        private  Card[]deck;

        //Makes object
        public Deck()
        {
            Card[] deck = new Card[7];
        }
        //Method to get the deck
        public Array getDeck()
        {
            return deck;
        }
        //Method to add random cards to deck
        public void createDeck()
        {
            for (int i = 0; i < 7; i++)
            {

                
            }
        }


    }

}
