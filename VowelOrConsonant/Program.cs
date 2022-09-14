using System;

namespace VowelOrConsonant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a character to check wheather it is Vowel or Consonant : ");
            char character = Convert.ToChar(Console.ReadLine().ToUpper());
            switch (character)
            {
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("Entered character is a Vowel");
                    break;
                default:
                    Console.WriteLine("Entered character is a Consonant");
                    break;
            }
        }
    }
}
