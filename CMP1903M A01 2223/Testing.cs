using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        public static void RunTest()
        {
            Pack testPack = new Pack();
            Pack.shuffleCardPack(testPack, 2);
            Console.WriteLine("Shuffled Deck");
            Console.WriteLine("Dealt {0}",Pack.deal(testPack));
            foreach (Card c in Pack.dealCard(testPack, 2))
            {
                Console.WriteLine("Dealt {0}", c);
            }
             
        }
    }
}
