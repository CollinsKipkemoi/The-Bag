using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Menu
    {
        private Methods mt;
        public Menu()
        {
            mt = new Methods();
        }
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
            Console.WriteLine($"Most frequent element: {mt.insert(element)}\n");
        }
        public void remove()
        {
            Console.Write("Enter the element to remove: ");
            int element = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine($"Most frequent element: {mt.remove(element)} \n");
            }
            catch (BagEmptyException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ElementNotInBagException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void returnFrequency()
        {
            try
            {
                Console.Write("Enter the element to check frequency: ");
                int element = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"The frequency of {element} is : {mt.return_Frequency(element)}");

            }
            catch (BagEmptyException e)
            {
                Console.WriteLine(e.Message + "!!");
            }
            catch (ElementNotInBagException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void most_freq()
        {
            try
            {
                Console.WriteLine($"most frequent element:  {mt.most_frequent()}");
            }
            catch (BagEmptyException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void printBag()
        {
            try
            {
                mt.print_the_bag();
            }
            catch (BagEmptyException e)
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
                        returnFrequency();
                        break;
                    case 4:
                        most_freq();
                        break;
                    case 5:
                        printBag();
                        break;
                }
                if (opt > 5 || opt < 0)
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
