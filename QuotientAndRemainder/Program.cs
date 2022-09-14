using System;

namespace QuotientAndRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividend, divisor, quotient, remainder;

            Console.WriteLine("Enter Dividend and divisor");
            dividend = Convert.ToInt32(Console.ReadLine());
            divisor = Convert.ToInt32(Console.ReadLine());

            quotient = dividend / divisor;
            remainder = dividend % divisor;

            Console.WriteLine("Quotient is " + quotient);
            Console.WriteLine("Remainder is " + remainder);
        }
    }
    
}
