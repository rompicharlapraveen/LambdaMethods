using System;
using System.Linq;

namespace LambdaMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //public static TSource Aggregate<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func);

            /* string sentence = "Praveen Rompicharla";

            string[] words = sentence.Split(' ');

            string reversed = words.Aggregate((workingSentence, next) =>
                                                  next + " " + workingSentence);

            Console.WriteLine(reversed);
            Console.ReadLine();
            */

            // public static TAccumulate Aggregate<TSource, TAccumulate>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func);

            /* int[] ints = { 4, 8, 8, 3, 9, 0, 7, 8, 2 };
             int numEven = ints.Aggregate(0, (total, next) =>
                                                 next % 2 == 0 ? total + 1 : total);

             Console.WriteLine("The number of even integers is: {0}", numEven);
             Console.ReadLine();
            */

            // public static TResult Aggregate<TSource, TAccumulate, TResult>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector);

            string[] fruits = { "apple", "mango", "orange", "passionfruit", "grape" };

            // Determine whether any string in the array is longer than "banana".
            string longestName = fruits.Aggregate("banana",(longest, next) => next.Length > longest.Length ? next : longest,
                                // Return the final result as an upper case string.
                                fruit => fruit.ToUpper());

            Console.WriteLine("The fruit with the longest name is {0}.",longestName);
            Console.ReadLine();
        }
    }
}
