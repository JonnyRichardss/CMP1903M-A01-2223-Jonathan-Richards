using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        public int Value
        {
            get { return Value; }
            set { if (0 < value && value < 14) Value = value; }
        }
        public int Suit { 
            get { return Suit; } 
            set {if (0 < value && value < 5) Suit = value;}
        }

        public Card(int val, int suit)
        {
            Value = val;
            Suit = suit;
        }
    }
}
