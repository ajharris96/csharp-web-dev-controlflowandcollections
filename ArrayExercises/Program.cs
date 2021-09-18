using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Arrays!");
            int[] nums = new int[6]{ 1, 1, 2, 3, 5, 8 };
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Now only odds");
            foreach (int num in nums)
            {
                if (num % 2 == 1)
                {
                    Console.WriteLine(num);
                }
               
            }

        }
    }
}
