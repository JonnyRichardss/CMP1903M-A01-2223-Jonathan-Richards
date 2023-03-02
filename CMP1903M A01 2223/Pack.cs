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
            return new List<Card>();
        }
        
    
        //Private methods - different card shuffles
        private static List<Card> FYShuffle(List<Card> prevorder)
        {
            return prevorder;
        }
        private static List<Card> RiffleShuffle(List<Card> prevorder)
        {
            //I've assumed that this is supposed to be a 'perfect' riffle shuffle (AKA faro / pharaoh shuffle)

            List<Card> topPile = prevorder.GetRange(0,prevorder.Count()/2);
            List<Card> bottomPile = prevorder.GetRange(prevorder.Count() /2,prevorder.Count/2);
            
            return prevorder;
        }
    }
}
