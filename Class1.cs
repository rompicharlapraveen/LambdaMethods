using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaMethods
{

    // public static IEnumerable<TSource> Append<TSource>(this IEnumerable<TSource> source, TSource element);

    /*
    class Class1
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4 };

            // Trying to append any value of the same type
            numbers.Append(5);

            // It doesn't work because the original list has not been changed
            Console.WriteLine(string.Join(", ", numbers));

            // It works now because we are using a changed copy of the original list
            Console.WriteLine(string.Join(", ", numbers.Append(5)));

            // If you prefer, you can create a new list explicitly
            List<int> newNumbers = numbers.Append(5).ToList();

            // And then write to the console output
            Console.WriteLine(string.Join(", ", newNumbers));
            Console.ReadLine();
        }
    }
    */
    // Custom class.
    class Clump<T> : List<T>
    {
        // Custom implementation of Where().
        public IEnumerable<T> Where(Func<T, bool> predicate)
        {
            Console.WriteLine("In Clump's implementation of Where().");
            return Enumerable.Where(this, predicate);
        }
    }
    class class1
    {
        public static void Main(string[] args)
        {
            // Create a new Clump<T> object.
            Clump<string> fruitClump =
                new Clump<string> { "apple", "passionfruit", "banana",
            "mango", "orange", "blueberry", "grape", "strawberry" };

            // First call to Where():
            // Call Clump's Where() method with a predicate.
            IEnumerable<string> query1 =
                fruitClump.Where(fruit => fruit.Contains("o"));

            Console.WriteLine("query1 has been created.\n");

            // Second call to Where():
            // First call AsEnumerable() to hide Clump's Where() method and thereby
            // force System.Linq.Enumerable's Where() method to be called.
            IEnumerable<string> query2 =
                fruitClump.AsEnumerable().Where(fruit => fruit.Contains("o"));

            // Display the output.
            Console.WriteLine("query2 has been created.");
        }
    }    
}
