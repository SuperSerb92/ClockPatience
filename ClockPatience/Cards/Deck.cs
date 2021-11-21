using System;
using System.Collections.Generic;
using System.Text;

namespace ClockPatience.Cards
{
  public  class Deck
    {
        List<Card> deck;

        public Deck()
        {
            deck = new List<Card>();

            for (int s = 0; s < 4; s++)
            {
                for (int v = 0; v < 13; v++)
                {


                    Card card = new Card(s.ToString(), v.ToString());
                    deck.Add(card);
                }
            }
        }
    }
}
