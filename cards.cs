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
                if (card1 < 11)
                {
                    Console.WriteLine(card1);
                }
                else
                {
                    if (card1 == 11)
                    {
                        Console.WriteLine("J");
                    }
                    else if (card1 == 12)
                    {
                        Console.WriteLine("Q");
                    }
                    else if (card1 == 13)
                    {
                        Console.WriteLine("K");
                    }
                    else if (card1 == 14)
                    {
                        Console.WriteLine("A");
                    }
                    else
                    {
                        Console.WriteLine("JOKER!");
                    }
                }


                // go to sleep
                System.Threading.Thread.Sleep(300);

                Console.WriteLine("Computer Card:");
                // me vrs computer
                // get random card
                int card2 = r.Next(2, 15);

                // print the card
                if (card2 < 11)
                {
                    Console.WriteLine(card2);
                }
                else
                {
                    if (card2 == 11)
                    {
                        Console.WriteLine("J");
                    }
                    else if (card2 == 12)
                    {
                        Console.WriteLine("Q");
                    }
                    else if (card2 == 13)
                    {
                        Console.WriteLine("K");
                    }
                    else if (card2 == 14)
                    {
                        Console.WriteLine("A");
                    }
                    else
                    {
                        Console.WriteLine("JOKER!");
                    }
                }

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
                Console.Write("My score = ");
                Console.WriteLine(myscore);
                Console.Write("Computer score = ");
                Console.WriteLine(computerscore);

                if (myscore != 5 && computerscore != 5)
                {
                    Console.WriteLine("Ready for another round?");
                    Console.ReadLine();
                }
            }
            Console.WriteLine("--- Game Over ---");
        }
    }
}
