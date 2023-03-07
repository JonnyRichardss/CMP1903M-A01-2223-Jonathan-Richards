using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        public static void RunStaticTest()
        {
            Console.WriteLine("STARTING STATIC TEST");
            Pack testPack = new Pack();
            if (testPack.shuffleCardPack(1))
            {
                Console.WriteLine("Shuffled Deck");
            }
            

            Console.WriteLine("Dealt {0}",testPack.deal()); //no try-catch as this will never have an empty pack

            foreach (Card c in testPack.dealCard(2))
            {
                Console.WriteLine("Dealt {0}", c);
            }
            Console.WriteLine("ENDING STATIC TEST");
        }
        public static void TestingMenu()
        {
            Pack testPack = new Pack();
            bool exit = false;
            string input;
            int menuInt;
            while (!exit)
            {
                Console.WriteLine("Testing Menu - Select an option: \n1 - Shuffle pack \n2 - Deal one card \n3 - Deal multiple cards \n4 - Reset pack \n5 - Exit");
                input = Console.ReadLine();
                if(int.TryParse(input,out menuInt))
                {
                    switch (menuInt)
                    {
                        case 1:
                            Console.WriteLine("Shuffle Type: \n1 - Fisher-Yates \n  2 - Riffle \n3 - None");
                            input = Console.ReadLine();
                            if (int.TryParse(input, out menuInt))
                            {
                                switch (menuInt)
                                {
                                    case 1:
                                        if (testPack.shuffleCardPack(1))
                                        {
                                            Console.WriteLine("Successfully Fisher-Yates shuffled!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Shuffle Failed!");
                                        }
                                        continue;
                                    case 2:
                                        if (testPack.shuffleCardPack(2))
                                        {
                                            Console.WriteLine("Successfully Riffle shuffled!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Shuffle Failed!");
                                        }
                                        continue;
                                    case 3:
                                        if (testPack.shuffleCardPack(3))
                                        {
                                            Console.WriteLine("Successfully done no shuffle!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Shuffle Failed!");
                                        }
                                        continue;
                                    default:
                                        Console.WriteLine("Not one of the options!");
                                        continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Input was not an integer!");
                                continue;
                            }
                        case 2:
                            try
                            { 
                            Console.WriteLine("Dealt {0}", testPack.deal());
                            }
                            catch (PackEmptyException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            continue;
                        case 3:
                            Console.WriteLine("How many to deal?");
                            input = Console.ReadLine();
                            if (int.TryParse(input, out menuInt))
                            {
                                try
                                {
                                    foreach (Card c in testPack.dealCard(menuInt))
                                    {
                                        Console.WriteLine("Dealt {0}", c);
                                    }
                                }
                                catch (PackEmptyException e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                
                            }
                            else
                            {
                                Console.WriteLine("Input was not an integer!");
                                continue;
                            }
                            break;
                        case 4:
                            testPack = new Pack();
                            Console.WriteLine("Reset Pack!");
                            continue;
                        case 5:
                            exit = true;
                            continue;
                        default:
                            Console.WriteLine("Not one of the options!");
                            continue;
                    }
                }
                else
                {
                    Console.WriteLine("Input was not an integer!");
                    continue;
                }
            }
        }
    }
}
