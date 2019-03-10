using System;
using System.Collections.Generic;

namespace SimplerMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> predators = new List<string>() { "Spider", "Bee", "Ants" };
            List<string> prey = new List<string>() { "Dog", "Hawk", "Snake" };

            Bug bigBug = new Bug("Huge Bug", "Insect", predators, prey);

            Console.WriteLine($"{bigBug.FormalName} eats {bigBug.PreyList()}");
            Console.WriteLine($"{bigBug.FormalName} steers clear of {bigBug.PredatorList()}");
            Console.WriteLine(bigBug.Eat("Snake"));
            Console.WriteLine(bigBug.Eat("Squirrel"));

            Console.ReadLine();
        }
    }
}
