using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1411hw
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            int i1 = 1;
            while (i1 <= 2000)
            {
                Console.WriteLine(i1);
                i1++;
            }

            for (int i = 1; i <= 2000; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 2; i <= 100; i = i + 2)
            {
                Console.WriteLine(i);
            }


            for (int i = 10; i <= 100; i = i + 10)
            {
                Console.WriteLine(i);
            }

            // 2
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            // 3
            
            int a = Convert.ToInt32(Console.ReadLine());

             //if has two digits? >=10 and <= 99
            if (a >= 10 && a <= 99) // for or do this ||
            {
                 //has two digits

                 //calc ahadot
                int ahadot = a % 10;
                Console.WriteLine("ahadot is: ");
                Console.WriteLine( ahadot );

                 //calc ahadot
                int asarot = a / 10;
                Console.WriteLine("asarot is: ");
                Console.WriteLine(ahadot);

                if (asarot > ahadot)
                {
                    Console.WriteLine("Asarot is bigger !");
                }
                else if (asarot == ahadot)
                {
                    Console.WriteLine("Equal!");
                }
                else
                {
                    Console.WriteLine("Ahadot is bigger !");
                }
            }

             // 4

             // first we test ourselves -can we find if number is prime ?
             int m1 = 2;
             int x1 = Convert.ToInt32(Console.ReadLine());
             while (x1 % m1 != 0 && m1 < x1)
             {
                 m1++;
             }
             if (x1 == m1)
             {
                 Console.WriteLine("Rishoni");
             }
             else
             {
                 Console.WriteLine("Lo Rishoni!");
             }

            for (int j = 1; j <= 100; j++)
            {


                int m = 2;
                //int x = Convert.ToInt32(Console.ReadLine());

                int x = j; // not from user, from for loop

                while (x % m != 0 && m < x)
                {
                    m++;
                }
                if (x == m || x == 1)
                {
                    Console.Write(j);
                    Console.WriteLine(" Rishoni");
                }
                else
                {
                    Console.Write(j);
                    Console.WriteLine(" Lo Rishoni!");
                }


            }

            // 5
            int money = Convert.ToInt32(Console.ReadLine());
            if (money >= 200)
            {
                int mataaimBills = money / 200;
                money = money - mataaimBills * 200;
                Console.Write("200 x ");
                Console.WriteLine(mataaimBills);
            }
            if (money >= 100)
            {
                int meaBills = money / 100;
                money = money - meaBills * 100;
                Console.Write("100 x ");
                Console.WriteLine(meaBills);
            }
            if (money >= 50)
            {
                int hamishimBills = money / 50;
                money = money - hamishimBills * 50;
                Console.Write("50 x ");
                Console.WriteLine(hamishimBills);
            }
            if (money >= 20)
            {
                int esrimBills = money / 20;
                money = money - esrimBills * 20;
                Console.Write("20 x ");
                Console.WriteLine(esrimBills);
            }

            // 6
            // solution 1
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result:");
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    if (j > i)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Result:");
            for (int i2 = 1; i2 <= size; i2++)
            {
                for (int j = 1; j <= i2; j++)
                {
                    Console.Write( j );
                }

                for (int j = i2 + 1; j <= size; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
