using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static double SumOfEvens(List<double> arg)
        {
            double sum = 0.0;
            for (int i = 0; i < arg.Count; i++)
            {
                if (arg[i] % 2 == 0)
                {
                    sum += arg[i];
                }
            }
            return sum;
        }

        static void PrintIfLengthFive(List<string> arg)
        {
            foreach (string word in arg)
            {
                if (word.Length == 5)
                {
                    Console.WriteLine(word);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lists!");
            List<double> nums = new List<double> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("the sum of the evens in the list is " + SumOfEvens(nums));
            List<string> words = new List<string> { "hello", "five", "seven", "yellow", "apple", "sdfsd" };
            PrintIfLengthFive(words);
        }
        
    }
}
