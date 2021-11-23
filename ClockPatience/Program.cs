using ClockPatience.Cards;
using System;

namespace ClockPatience
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string input = Console.ReadLine();


            string line = "";

            while (line != "#")
            {
                line = Console.ReadLine();
                if (line != "#")
                {
                    input += " " + line;
                }                
            }
            //Start the game
            Deck d = new Deck(input);

            Console.ReadLine();
        }
    }
}
