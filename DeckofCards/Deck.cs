using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckofCards
{
    class Deck
    {
        private Card[] deck;
        private int curr;
        private Random ranNum;

        public Deck()
        {
            string[] faces = {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Spades", "Clubs", "Diamonds" };

            deck = new Card[52];
            curr = 0;
            ranNum = new Random();

            for(int i = 0; i < deck.Length; i++)
            {
                deck[i] = new Card(faces[i % 11], suits[i / 13]);
            }


        }

        // Displays one card at a time
        public Card Draw()
        {

            if(curr < deck.Length)
            {
                return deck[curr++];
            }
            else
            {
                return null;
            }
        }

        // shuffles a 52-card deck 
        public void Shuffle()
        {
            curr = 0;
            for(int j = 0; j < deck.Length; j++)
            {
                int k = ranNum.Next(52);
                Card temp = deck[j];
                deck[j] = deck[k];
                deck[k] = temp;
            }

            System.Console.WriteLine("==============================================================");
            System.Console.WriteLine("\nYour deck has now been shuffled. ");
            System.Console.WriteLine("==============================================================");


        }
    }
}
