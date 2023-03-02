﻿using System;
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
    }
}
