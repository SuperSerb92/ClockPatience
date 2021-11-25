using System;
using System.Collections.Generic;
using System.Text;

namespace ClockPatience.Cards
{
  public  class Deck
    {
        List<Card> deck;
        public int CurrentStack;
        List<Card>[] FaceUp { get;  set; }
         List<Card>[] FaceDown { get; set; }
        public Deck(string input)
        {
            deck = new List<Card>();
            string[] cards = input.Split(' ');


            foreach (var item in cards)
            {
               string value= item.Substring(0, 1);
               string suit = item.Substring(1, 1);
                Card card = new Card(value,suit);
                deck.Add(card);
            }


        }

        public Card DealCard()
        {
            if (deck.Count == 0) return null;

            Card c = new Card();
            int i = deck.Count - 1;
            c = deck[i];
            deck.RemoveAt(i);
            return c;
        }

    
}
}
