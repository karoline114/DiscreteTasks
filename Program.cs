using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_Dr_Samir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Number : ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------------");

            Console.WriteLine("Enter Second Number : ");
            int y = int.Parse(Console.ReadLine());

            int sum;

            Console.WriteLine("--------------------------------");

            for (int i = x; i <= y; i++)
            {
                sum = 0;

                for (int j = 1; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }

                }
                if (sum == i)
                {
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
