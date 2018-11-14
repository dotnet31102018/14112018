using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1411_cards
{
    class Program
    {
        static void Main(string[] args)
        {

            int myscore = 0;
            int computerscore = 0;

            while (myscore < 5 && computerscore < 5)
            {

                // whoes bigger?
                // card1 > card2 ?

                Console.WriteLine("My Card:");

                // me vrs computer
                // get random card
                Random r = new Random();
                int card1 = r.Next(2, 15);

                // print the card

                PrintCard(card1);

                // go to sleep
                System.Threading.Thread.Sleep(300);

                Console.WriteLine("Computer Card:");
                // me vrs computer
                // get random card
                int card2 = r.Next(2, 15);

                PrintCard(card2);

                // check who won
                if (card1 > card2)
                {
                    // i won
                    myscore++;
                    Console.WriteLine("Player won!");
                }
                else if (card1 == card2)
                {
                    // tie
                    Console.WriteLine("Its a tie!!!");
                }
                else
                {
                    // computer won
                    computerscore++;
                    Console.WriteLine("Computer won!");
                }

                PrintScore(myscore, computerscore);

                if (myscore != 5 && computerscore != 5)
                {
                    Console.WriteLine("Ready for another round?");
                    Console.ReadLine();
                }
            }
            Console.WriteLine("--- Game Over ---");
        }

        private static void PrintScore(int myscore, int computerscore)
        {
            Console.Write("My score = ");
            Console.WriteLine(myscore);
            Console.Write("Computer score = ");
            Console.WriteLine(computerscore);
        }

        private static void PrintCard(int card1)
        {
            switch (card1)
            {
                case 11:
                    Console.WriteLine("J");
                    break;
                case 12:
                    Console.WriteLine("Q");
                    break;
                case 13:
                    Console.WriteLine("K");
                    break;
                case 14:
                    Console.WriteLine("A");
                    break;
                case 15:
                    Console.WriteLine("JOKER!!");
                    break;
                default:
                    Console.WriteLine(card1);
                    break;
            }
        }
    }
}
