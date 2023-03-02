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

        public static bool shuffleCardPack(Pack currentPack,int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            switch(typeOfShuffle)
            {
                case 1:
                    currentPack.pack = FYShuffle(currentPack.pack);
                    break;
                case 2:
                    currentPack.pack = RiffleShuffle(currentPack.pack);
                    break;
                case 3:
                    //currentPack.pack = currentPack.pack; dont need to do anything to not shuffle
                    break;
                default:
                    return false;

            }
            return true;
        }
        public static Card deal(Pack currentPack)
        {
            //Deals one card
            return currentPack.pack[0];
        }
        public static List<Card> dealCard(Pack currentPack,int amount)
        {
            //Deals the number of cards specified by 'amount'

            List<Card> output = new List<Card>(); //init output

            //calls deal 'amount' times and adds to output
            for (int i = 0; i < amount; i++)
            {
                
                output.Add(deal(currentPack));
            }
            
            return output;
        }
        
    
        //Private methods - different card shuffles
        private static List<Card> FYShuffle(List<Card> prevorder)
        {
            //TODO
            return prevorder;
        }
        private static List<Card> RiffleShuffle(List<Card> prevorder)
        {
            List<Card> output = new List<Card>();
            //I've assumed that this is supposed to be a 'perfect' riffle shuffle (AKA faro / pharaoh shuffle)

            //split deck into two piles
            List<Card> topPile = prevorder.GetRange(0,prevorder.Count()/2);
            List<Card> bottomPile = prevorder.GetRange(prevorder.Count() /2,prevorder.Count/2);
            
            //reconstruct deck using alternate cards from each pile
            for (int i =0; i< prevorder.Count / 2; i++)
            {
                output.Add(topPile[i]);
                output.Add(bottomPile[i]);
            }
            return output;
        }
    }
}
