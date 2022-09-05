using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckofCards
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string upper;

            Deck deck1 = new Deck();

            Header();
            
            do
            {
                input = getInput();
                upper = input.ToUpper();

                switch (upper)
                {
                    case "N":
                        Deck temp_deck = new Deck();
                        deck1 = temp_deck;

                        System.Console.WriteLine("==============================================================");
                        Console.WriteLine("You now have a new deck!");
                        System.Console.WriteLine("==============================================================");

                        break;
                    case "D":
                        int x = 0;

                        // left aligned text
                        Console.Write("{0, -25}", deck1.Draw());
                        if ((x + 1) % 4 < 5)
                        {
                            Console.WriteLine();
                        }
                        break;
                    case "R":
                        for (int i = 0; i < 52; i++)
                        {
                            // left aligned
                            Console.Write("{0, -25}", deck1.Draw());
                            if ((i + 1) % 4 == 0)
                            {
                                Console.WriteLine();
                            }
                        }
                        System.Console.WriteLine("\n**Your deck is empty. Please create a new one. ");
                        break;
                    case "S":
                        deck1.Shuffle();
                        break;
                    default:
                        Console.WriteLine("\n**Invalid Input. \n");
                        break;
                }

            } while (upper != "Q");
            Environment.Exit(0);
        }



        private static void Header()
        {
            System.Console.WriteLine("This is a Deck of 52 Cards\n\n");
        }

        private static string getInput()
        {
            System.Console.WriteLine("\n\nSelect any of the following: ");
            System.Console.WriteLine("\nN : Get a new deck ");
            System.Console.WriteLine("D : Draw a card ");
            System.Console.WriteLine("R : Show all cards ");
            System.Console.WriteLine("S : Shuffle cards ");
            System.Console.WriteLine("Q : Quit \n\n");
            var inputStr = System.Console.ReadLine();

            return inputStr;

        }
    }
}
