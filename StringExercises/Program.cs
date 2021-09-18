﻿using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Strings!");
            string example = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            string[] words = example.Split(" ");
            Console.WriteLine(string.Join(",", words));
            string[] sentences = example.Split(". ");
            Console.WriteLine(string.Join(". ", sentences));
        }
    }
}
