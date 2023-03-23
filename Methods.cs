using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bag_Ass1
{
    public class Methods
    {

        public class BagEmptyException : Exception
        {
            public BagEmptyException() { }
            public BagEmptyException(string message)
                : base(message)
            {

            }
        };
        public class ElementNotInBagException : Exception
        {
            public ElementNotInBagException() { }
            public ElementNotInBagException(string message)
                : base(message)
            {

            }
        }

        //!INSERTING AN ELEMENT
        public void insert(List<List<int>> bag, in int num)
        {
            int length = bag.Count;
            if (length == 0)
            {
                bag.Add(new List<int> { num, 1 });
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    if (bag[i][0] == num)
                    {
                        bag[i][1]++;
                        break;
                    }
                    else if (i == length - 1)
                    {
                        bag.Add(new List<int> { num, 1 });
                        break;
                    }
                }

            }
        }

        //!REMOVE AN ELEMENT FROM THE BAG
        public void remove(List<List<int>> bag, in int rem_Num)
        {
            //we first check if the element is in the bag
            int length = bag.Count;

            if (length == 0)
            {
                Console.WriteLine("Bag is Empty!!");
                return;
            }
            else
            {
                bool is_In = false;
                for (int i = 0; i < length; i++)
                {
                    if (bag[i][0] == rem_Num)
                    {
                        is_In = true;
                        break;
                    }
                }



                if (is_In)
                {
                    for (int i = 0; i < length; i++)
                    {

                        if (bag[i][0] == rem_Num)
                        {
                            if (bag[i][1] == 1)
                            {
                                bag.RemoveAt(i);
                                break;
                            }
                            else
                            {
                                bag[i][1]--;
                                break;
                            }
                        }

                    }
                }
                else if (is_In == false && length != 0)
                {
                    //throw new ElementNotInBagException("The element is not in the bag!!");
                    Console.WriteLine("Number not in the bag!!\n");
                }


            }




        }

        //!RETURN THE FREQUENCY
        public void return_Frequency(List<List<int>> bag, in int num_Return)
        {
            int length = bag.Count;
            if (length == 0)
            {
                Console.WriteLine("Error!!Bag empty!!");
                return;
            }
            else
            {
                //Check if the number is in the bag
                bool is_In = false;
                int frequency = 0;
                for (int i = 0; i < length; i++)
                {
                    if (bag[i][0] == num_Return)
                    {
                        is_In = true;
                        break;
                    }

                }
                //return the frequency if it is in the bag and throw an error if not in thr bag.
                if (is_In)
                {
                    for (int i = 0; i < length; i++)
                    {
                        if (bag[i][0] == num_Return)
                        {
                            frequency = bag[i][1];
                            break;
                        }
                    }
                    Console.WriteLine($"Frequency of {num_Return}: {frequency}");
                }
                else
                {
                    Console.WriteLine($"Error!!{num_Return} is not in the bag!!");
                }
            }
        }

        //!RETURNING THE MOST FREQUENT ELEMENT FROM THE BAG
        public void most_frequent(List<List<int>> bag)
        {
            int length = bag.Count;
            if (length == 0)
            {
                Console.WriteLine("Error!!Bag empty!!");
            }
            else
            {
                int frequency = 0;
                int most_freq = 0;
                for (int i = 0; i < length; i++)
                {
                    if (bag[i][1] > frequency)
                    {
                        most_freq = bag[i][0];
                        frequency = bag[i][1];
                    }
                }
                Console.WriteLine($"Most frequent element: {most_freq}");
            }
        }

        public void print_the_bag(List<List<int>> bag)
        {
            if (bag.Count == 0)
            {
                //empty bag
                Console.WriteLine("Bag empty!!\n");
            }
            else
            {
                Console.WriteLine("\n\nThe bag in pairs of {element,frequency} is as follows:");
                for (int i = 0; i < bag.Count; i++)
                {
                    for (int j = 0; j < bag[i].Count; j++)
                    {
                        Console.Write("\t" + bag[i][j] + " ");
                    }
                    Console.WriteLine("");
                }
            }
        }

    }
}
