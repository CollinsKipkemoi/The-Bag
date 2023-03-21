using System;
using System.Linq;
using System.Collections.Generic;
namespace Bag_Ass1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> numbers_bags = new List<List<int>>();
            Methods m1 = new Methods();

            m1.insert(numbers_bags, 20);
            m1.insert(numbers_bags, 15);
            m1.insert(numbers_bags, 15);
            m1.insert(numbers_bags, 15);
            m1.insert(numbers_bags, 15);
            m1.insert(numbers_bags, 15);
            m1.insert(numbers_bags, 100);
            m1.insert(numbers_bags, 100);
            m1.insert(numbers_bags, 100);
            m1.insert(numbers_bags, 100);
            m1.insert(numbers_bags, 100);
            m1.remove(numbers_bags, 1000);
            m1.return_Frequency(numbers_bags, 100);
            Console.WriteLine("");
            m1.most_frequent(numbers_bags);
            m1.print_the_bag(numbers_bags);

        }
    }
}