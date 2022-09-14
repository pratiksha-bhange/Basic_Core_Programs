using System;

namespace LargestThreeNo
{
    class Program
    {
        static void Main(string[] args)
        {
            int first;
            int second;
            int third;

            Console.WriteLine("Enter the first number : ");
            first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            second = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number : ");
            third = int.Parse(Console.ReadLine());

            int maxValue = Math.Max(Math.Max(first, second), third);

            Console.WriteLine("Largest value : " + maxValue);
        }
    }
}
