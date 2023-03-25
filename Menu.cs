using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bag_Ass1
{
    public class Menu
    {
        private Methods mt;
        public Menu()
        {
            mt = new Methods();
        }
        List<List<int>> bag = new List<List<int>>();
        public int option()
        {
            Console.WriteLine("0. Exit!");
            Console.WriteLine("1. Insert an element");
            Console.WriteLine("2. Remove an element");
            Console.WriteLine("3. Return the Frequency of an element");
            Console.WriteLine("4. Return the most frequent element");
            Console.WriteLine("5. Print the bag");
            Console.Write("\nChoose an option from the menu: ");
            int opt = Convert.ToInt32(Console.ReadLine());
            return opt;
        }
        public void Insert()
        {
            Console.Write("Enter the element to insert: ");
            int element = Convert.ToInt32(Console.ReadLine());
            mt.insert(bag, element);
        }
        public void remove()
        {
            Console.Write("Enter the element to remove: ");
            int element = Convert.ToInt32(Console.ReadLine());
            try
            {
                mt.remove(bag, element);
            }
            catch (BagEmptyException)
            {
                throw new BagEmptyException("Bag is Empty");
            }

        }
        public void frequency()
        {
            try
            {
                Console.Write("Enter the element to check frequency: ");
                int element = Convert.ToInt32(Console.ReadLine());
                mt.return_Frequency(bag, element);

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void most_freq()
        {
            try
            {
                mt.most_frequent(bag);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void printBag()
        {
            try
            {
                mt.print_the_bag(bag);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Run()
        {
            int opt;
            do
            {
                opt = option();
                switch (opt)
                {
                    case 1:
                        Insert();
                        break;
                    case 2:
                        remove();
                        break;
                    case 3:
                        frequency();
                        break;
                    case 4:
                        most_freq();
                        break;
                    case 5:
                        printBag();
                        break;
                }
                if (opt != 0 && opt > 5 && opt < 0)
                {
                    Console.WriteLine("Unsupported Operation!!");
                }
            } while (opt != 0);
            {
                Console.WriteLine("Exit successfully!!");
            };

        }
    }
}
