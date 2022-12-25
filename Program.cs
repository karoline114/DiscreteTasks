using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_Dr_Samir
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Frist Number");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("------------------------------");

            Console.WriteLine("enter second number");
            int y = int.Parse(Console.ReadLine());

            bool isPrime;
            Console.WriteLine("------------------------------");

            for (int j = x; j <= y; j++)
            {
                isPrime = true;
                for (int i = 2; i <= j / 2; i++)
                {
                    if (j % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
