using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace LambdaMethods
{
    // public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value);
    /*
    class Class4
    {
       public static void Main(string[] args)
        {
            string[] fruits = { "Mango","Banana","Grapes"};
            string fruit = "Banana";
            bool hasMango = fruits.Contains(fruit);

            Console.WriteLine(
                "The array {0} contain '{1}'.",
                hasMango ? "does" : "does not",
                fruit);
        }
    }
    */

    // public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer);

    public class Class4
    {
        public static void Main(String[] argv)
        {
            Product[] fruits = { new Product { Name = "apple", Code = 9 },
                               new Product { Name = "orange", Code = 4 },
                               new Product { Name = "lemon", Code = 12 } };

            Product apple = new Product { Name = "apple", Code = 9 };
            Product kiwi = new Product { Name = "kiwi", Code = 8 };

            ProductComparer prodc = new ProductComparer();

            bool hasApple = fruits.Contains(apple, prodc);
            bool hasKiwi = fruits.Contains(kiwi, prodc);

            Console.WriteLine("Apple? " + hasApple);
            Console.WriteLine("Kiwi? " + hasKiwi);

        }
    }

    public class Product
    {
        public string Name { get; set; }
        public int Code { get; set; }
    }
    class ProductComparer : IEqualityComparer<Product>
    {
        public Boolean Equals(Product x, Product y)
        {
            return x.Code == y.Code;
        }
        public int GetHashCode(Product product)
        {
            int hashProductCode = product.Code.GetHashCode();
            return hashProductCode;
        }
    }
}
