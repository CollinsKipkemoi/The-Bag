using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{

    public class Methods
    {

        public List<List<int>> bag;

        public Methods()
        {
            bag = new List<List<int>>();
        }


        //!INSERTING AN ELEMENT
        public int insert(in int num)
        {
            int baglength = bag.Count;
            if (baglength == 0)
            {
                bag.Add(new List<int> { num, 1 });

            }
            else
            {
                for (int i = 0; i < baglength; i++)
                {
                    if (bag[i][0] == num)
                    {
                        bag[i][1]++;
                        break;
                    }
                    else if (i == baglength - 1)
                    {
                        bag.Add(new List<int> { num, 1 });
                        break;
                    }
                }

            }

            int highestFrequency = 0;
            int mostFrequent = 0;
            for (int i = 0; i < bag.Count; i++)
            {
                if (bag[i][1] > highestFrequency)
                {
                    highestFrequency = bag[i][1];
                    mostFrequent = bag[i][0];
                }
            }
            return mostFrequent;
        }

        //!REMOVE AN ELEMENT FROM THE BAG
        public int remove(in int rem_Num)
        {
            int baglength = bag.Count;
            if (baglength == 0)
            {
                throw new BagEmptyException("Error: Bag is empty!");
            }
            bool is_In = false;
            for (int i = 0; i < baglength; i++)
            {
                if (bag[i][0] == rem_Num)
                {
                    is_In = true;
                    break;
                }
            }

            if (is_In == true)
            {
                for (int i = 0; i < baglength; i++)
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
                            bag[i][1] = bag[i][1] - 1;
                            break;
                        }
                    }

                }
            }
            else if (is_In == false && baglength != 0)
            {
                throw new ElementNotInBagException("Number not in bag!!");
            }
            int highestFrequency = 0;
            int MostFrequentElement = 0;
            for (int i = 0; i < bag.Count; i++)
            {
                if (bag[i][1] > highestFrequency)
                {
                    highestFrequency = bag[i][1];
                    MostFrequentElement = bag[i][0];
                }
            }
            return MostFrequentElement;

        }


        //!RETURN THE FREQUENCY
        public int return_Frequency(in int num_Return)
        {
            int baglength = bag.Count;
            int frequency = 0;
            if (baglength == 0)
            {
                throw new BagEmptyException("Error: Bag is Empty!!");
            }
            else
            {
                //Check if the number is in the bag
                bool is_In = false;
                for (int i = 0; i < baglength; i++)
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
                    for (int i = 0; i < baglength; i++)
                    {
                        if (bag[i][0] == num_Return)
                        {
                            frequency = bag[i][1];
                            break;
                        }
                    }

                }
                else
                {
                    throw new ElementNotInBagException("Number not in bag, cannot get the frequency!!");
                }
            }
            return frequency;
        }

        //!RETURNING THE MOST FREQUENT ELEMENT FROM THE BAG
        public int most_frequent()
        {
            int baglength = bag.Count;

            int most_freq = 0;
            if (baglength == 0)
            {
                throw new BagEmptyException("Error: Bag Empty!!");

            }
            else
            {
                int frequency = 0;
                for (int i = 0; i < baglength; i++)
                {
                    if (bag[i][1] > frequency)
                    {
                        most_freq = bag[i][0];
                        frequency = bag[i][1];
                    }
                }

            }
            return most_freq;
        }

        public void print_the_bag()
        {
            if (bag.Count == 0)
            {
                //empty bag
                throw new BagEmptyException("Bag is empty,Operation not possible!!");
            }
            else
            {
                Console.WriteLine("\n\nThe bag in pairs of {element,frequency} is as follows:");
                for (int i = 0; i < bag.Count; i++)
                {
                    string output = "{";

                    for (int j = 0; j < bag[i].Count; j++)
                    {
                        if (j == 0)
                        {
                            output += bag[i][j].ToString() + ",";
                        }

                        if (j == 1)
                        {
                            output += bag[i][j].ToString();
                            output += "}";
                        }

                    }
                    Console.WriteLine("\t" + output);
                }
                Console.WriteLine("");

            }
        }

    }
}
