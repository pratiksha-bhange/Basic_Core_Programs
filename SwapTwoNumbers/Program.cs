using System;

namespace SwapTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.Write("Enter the First Number : ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the Second Number : ");
            num2 = int.Parse(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.Write("After Swapping : ");
            Console.Write("\nFirst Number : " + num1);
            Console.Write("\nSecond Number : " + num2);

            Console.Read();
        }
    }
}
