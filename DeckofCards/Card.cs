using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckofCards
{
    class Card
    {
        private string face;
        private string suit;

        // constructor
        public Card(string cardFace, string cardSuit)
        {
            face = cardFace;
            suit = cardSuit;
        }

        // format for when we print out the Cards
        public override string ToString()
        {
            return face + " of " + suit;
        }

    }
}
