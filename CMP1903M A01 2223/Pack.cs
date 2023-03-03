using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        List<Card> pack;

        public Pack()
        {
            //Initialise the card pack here
            pack = new List<Card>();
            for(int s = 1; s < 5; s++)
            {
                for (int v = 1; v < 14; v++)
                {
                    pack.Add(new Card(v, s));
                }
            }
        }

        
        public bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            switch(typeOfShuffle)
            {
                case 1:
                    pack = FYShuffle();
                    break;
                case 2:
                    pack = RiffleShuffle();
                    break;
                case 3:
                    //currentPack.pack = currentPack.pack; dont need to do anything to not shuffle
                    break;
                default:
                    return false;

            }
            return true;
        }
        public  Card deal()
        {
            //Deals one card
            Card card = pack[0];
            pack.Remove(card);
            return card;
        }
        public  List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'

            List<Card> output = new List<Card>(); //init output

            //calls deal 'amount' times and adds to output
            for (int i = 0; i < amount; i++)
            {
                
                output.Add(deal());
            }
            
            return output;
        }
        
    
        //Private methods - different card shuffles
        private List<Card> FYShuffle()
        {
            //TODO
            //Write down the numbers from 1 through N.

            //Pick a random number k between one and the number of unstruck numbers remaining(inclusive).

            //Counting from the low end, strike out the kth number not yet struck out, and write it down at the end of a separate list.

            //Repeat from step 2 until all the numbers have been struck out.

            //The sequence of numbers written down in step 3 is now a random permutation of the original numbers.
            return pack;

        }
        private  List<Card> RiffleShuffle()
        {
            List<Card> output = new List<Card>();
            //I've assumed that this is supposed to be a 'perfect' riffle shuffle (AKA faro / pharaoh shuffle)

            //split deck into two piles
            List<Card> topPile = pack.GetRange(0,pack.Count()/2);
            List<Card> bottomPile = pack.GetRange(pack.Count() /2,pack.Count/2);
            
            //reconstruct deck using alternate cards from each pile
            for (int i =0; i< pack.Count / 2; i++)
            {
                output.Add(topPile[i]);
                output.Add(bottomPile[i]);
            }
            return output;
        }
    }
}
