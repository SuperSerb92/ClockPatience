using System;
using System.Collections.Generic;
using System.Text;

namespace ClockPatience.Cards
{
    public class Card
    {

        public string Value { get; }
        public string Suit { get; }
        public int ValueNo { get; set; }
        #region Constructor
        public Card()
        {

        }
        public Card(string Value,string Suit)
        {
            this.Value = Value;
            this.Suit = Suit;
            StringToInt(Value);
        }
        void StringToInt(string value)
        {
            switch (value)
            {
                case "A":
                    ValueNo = 0;
                    break;
                case "2":
                    ValueNo = 1;
                    break;
                case "3":
                    ValueNo = 2;
                    break;
                case "4":
                    ValueNo = 3;
                    break;
                case "5":
                    ValueNo = 4;
                    break;
                case "6":
                    ValueNo = 5;
                    break;
                case "7":
                    ValueNo = 6;
                    break;
                case "8":
                    ValueNo = 7;
                    break;
                case "9":
                    ValueNo = 8;
                    break;
                case "T":
                    ValueNo = 9;
                    break;
                case "J":
                    ValueNo = 10;
                    break;
                case "Q":
                    ValueNo = 11;
                    break;
                case "K":
                    ValueNo = 12;
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
