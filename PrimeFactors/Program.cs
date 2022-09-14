using System;

namespace PrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to print its prime factors:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Prime factors of {0} are: ", n);

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    int prime = 1;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            prime = 0;
                            break;
                        }
                    }
                    if (prime == 1)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
