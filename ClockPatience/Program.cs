using ClockPatience.Cards;
using System;
using System.Collections.Generic;

namespace ClockPatience
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int lineNo = 1;
            string line = "";
            List<string> decks = new List<string>();

            while (line != "#")
            {
                line = Console.ReadLine();
                lineNo++;
                if (lineNo==4)
                {

                    lineNo = 0;
                    input += " " + line;
                    decks.Add(input.TrimStart(' '));
                    input = string.Empty;
                }
                else
                {
                    if (line != "#")
                    {
                        input += " " + line;
                    }
                }
                          
            }
            //Start the game
            foreach (string item in decks)
            {
                Game g = new Game(item);

                Console.WriteLine(g.PlayCards());
            }
           
            Console.ReadLine();
        }
    }
}
