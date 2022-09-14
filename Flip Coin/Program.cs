using System;

namespace Flip_Coin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the number of times coin flip");
            int number = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int heads = 0;
            int tails = 0;
            int temp = number;
            while (number > 0)
            {
                if (random.NextDouble() <= 0.5)
                    heads++;
                else
                    tails++;
                number--;

            }
            number = temp;
            double percentageOfHead = heads * 100.0 / number;
            double percentageOfTail = tails * 100.0 / number;
            Console.WriteLine("Percentage of Head is " + percentageOfHead);
            Console.WriteLine("Percentage of tail is " + percentageOfTail);
        }
    }
}
