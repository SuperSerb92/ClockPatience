using System;
using System.Collections.Generic;
using System.Text;

namespace ClockPatience.Cards
{
    public class Card
    {
        string value;
        string suit;
        public string Value { get => value; set => this.value = value; }
        public string Suit { get => suit; set => suit = value; }

        #region Constructor
        public Card()
        {

        }
        public Card(string Value,string Suit)
        {
            this.value = Value;
            this.suit = Suit;
        }
        #endregion
    }
}
