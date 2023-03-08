using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public enum SuitEnum
    {
        ERROR = 0,
        hearts = 1,
        clubs = 2,
        diamonds = 3,
        spades = 4
    }
    class Card
    {
     
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        private int _value;
        private SuitEnum _suit;
        public int Value
        {
            get { return _value; }
            set { if (0 < value && value < 14) _value = value; }
        }
        public SuitEnum Suit { 
            get { return _suit; } 
            set { _suit = value;}
        }

        public Card(int val, SuitEnum suit)
        {
            Value = val;
            Suit = suit;
        }
        public Card(int val, int suit)
        {
            Value = val;
            Suit = (SuitEnum)suit;
        }
        //basic ToString for debugging - didn't bother to add face cards or aces, just used numbers
        public override string ToString()
        {
            //initialise string with value that makes it obvious if re-assignment fails

            //This switch *should* be a real enum that can be used elsewhere but oh well

            //assign correct suit text based on the suit the card has
            if(Suit == SuitEnum.ERROR)
            {
                return ("Nothing, end of pack reached!");
            }
            //return card name (human readable)
            return (String.Format("The {0} of {1}.",_value,Suit));
        }
    }
}
