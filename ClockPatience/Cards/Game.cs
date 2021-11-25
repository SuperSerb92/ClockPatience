using System;
using System.Collections.Generic;
using System.Text;

namespace ClockPatience.Cards
{
  public class Game
    {
        Deck deck;
        public int CurrentStack;
        List<Card>[] FaceUp { get; set; }
        List<Card>[] FaceDown { get; set; }
        public Game(string input)
        {
            deck = new Deck(input);

            FaceUp = new List<Card>[13];
            FaceDown = new List<Card>[13];

            Deal();
        }

        #region Methods
        public void Deal()
        {
            for (int i = 0; i < 13; i++)
            {
                FaceUp[i] = new List<Card>();
                FaceDown[i] = new List<Card>();
            }

            for (int round = 0; round < 4; round++)
            {
                for (int stack = 0; stack < 13; stack++)
                {
                    FaceDown[stack].Add(deck.DealCard());
                }
            }

            CurrentStack = 12;
        }
        int counter = 0;
        public string PlayCards()
        {
            try
            {
                while (FaceDown[CurrentStack].Count > 0)
                {
                    Card c = PopCard(FaceDown[CurrentStack]);
                    CurrentStack = c.ValueNo;
                    FaceUp[CurrentStack].Add(c);
                    counter++;
                }

                return counter.ToString()+", "+FaceUp[CurrentStack][FaceUp[CurrentStack].Count-1].Value+ FaceUp[CurrentStack][FaceUp[CurrentStack].Count - 1].Suit;
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        Card PopCard(List<Card> cards)
        {
            int index = cards.Count - 1;
            Card card = cards[index];
            cards.RemoveAt(index);

            return card;
        }
        #endregion
    }
}
