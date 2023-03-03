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
            testPack.shuffleCardPack(2);
            Console.WriteLine("Shuffled Deck");

            Console.WriteLine("Dealt {0}",testPack.deal());

            foreach (Card c in testPack.dealCard(2))
            {
                Console.WriteLine("Dealt {0}", c);
            }

        }
    }
}
