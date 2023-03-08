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
        private int _value;
        private SuitEnum _suit;

        //FOR SELF ASSESSMENT - the lack of 'set' methods here is an example of encapsulation as other classes cannot modify this class's data other than through the constructor
        public int Value
        {
            get { return _value; }
        }
        public SuitEnum Suit {
            get { return _suit; }
        }

        public Card(int val, SuitEnum suit)
        {
            if (0 < val && val < 14) _value = val;
            _suit = suit;
        }
        public Card(int val, int suit)
        {
            if (0 < val && val < 14) _value = val;
            _suit = (SuitEnum)suit;
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
