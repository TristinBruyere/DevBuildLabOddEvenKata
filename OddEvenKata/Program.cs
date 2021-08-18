using System;

namespace OddEvenKata
{
    public class OddEvenPrime
    {
        public static bool IsPrime(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static string OddEven(int num)
        {
            if (num % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
        public static void PrintOddEvenKata(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine("PRIME");
                }
                else
                {
                    Console.WriteLine(OddEven(i));
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int input = Int32.Parse(Console.ReadLine());
            OddEvenPrime.PrintOddEvenKata(input);
        }
    }
}
