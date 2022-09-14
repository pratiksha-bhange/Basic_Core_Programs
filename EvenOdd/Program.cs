using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any number");
            int Num = Convert.ToInt32(Console.ReadLine());
            if (Num % 2 == 0)
            {
                Console.WriteLine("Enter number is even");
            }
            else
            {
                Console.WriteLine("Enter number is odd");
            }
            Console.ReadLine();
        }
    }
}
