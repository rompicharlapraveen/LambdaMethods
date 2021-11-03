using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaMethods
{

    // public static bool All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
    /* class Pet1
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Pet
    {
        public static void AllEx(string[] args)
        {
            // Create an array of Pets
            Pet1[] pets = { new Pet1 { Name="Barley", Age=10 },
                   new Pet1 { Name="Boots", Age=4 },
                   new Pet1 { Name="Whiskers", Age=6 } };

            // Determine whether all pet names
            // in the array start with 'B'.
            bool allStartWithB = pets.All(pet => pet.Name.StartsWith("B"));

            Console.WriteLine("{0} pet names start with 'B'.", allStartWithB ? "All" : "Not all");
            Console.ReadLine();
        }
    }
    */

    // public static bool Any<TSource>(this IEnumerable<TSource> source);

    /*
    class Pet
    {
        public static void Main(string[] args)
        {

            List<int> numbers = new List<int> { 1, 2 };
            bool hasElements = numbers.Any();

            Console.WriteLine("The list {0} empty.", hasElements ? "is not" : "is");
            Console.ReadLine();
        }
    }
    */

    // public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);

    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Vaccinated { get; set; }
    }
    class Pet1
    {
        public static void Main(string[] args)
        {
            // Create an array of Pets.
            Pet[] pets =
                { new Pet { Name="Barley", Age=8, Vaccinated=true },
          new Pet { Name="Boots", Age=4, Vaccinated=false },
          new Pet { Name="Whiskers", Age=1, Vaccinated=false } };

            // Determine whether any pets over age 1 are also unvaccinated.
            bool unvaccinated = pets.Any(p => p.Age > 1 && p.Vaccinated == false);

            Console.WriteLine("There {0} unvaccinated animals over age one.",unvaccinated ? "are" : "are not any");
        }
    }
}
