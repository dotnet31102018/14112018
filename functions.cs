using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14411
{
    class Program
    {
        static void Main(string[] args)
        {
            NewMethod();

            Console.WriteLine("doing work...");

        }

        private static void NewMethod()
        {
            Console.WriteLine("Enter number for triangle:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }
        }
    }
}
