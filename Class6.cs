using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaMethods
{
    class Pets
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Class6
    {
        static void Main(string[] args)
        {
            //List<Pets> p = new List<Pets>
            //{  new Pets { Name="Barley", Age=8 },
            //   new Pets { Name="Boots", Age=4 },
            //   new Pets { Name="Whiskers", Age=1 } };
            //foreach(Pets pet in p.DefaultIfEmpty())
            //{
            //    Console.WriteLine(pet.Name);
           
            List<int> num = new List<int>();
            foreach (int number in num.DefaultIfEmpty())
            {
                Console.WriteLine(number);
                Console.ReadLine();
            }
        }
    }
}
