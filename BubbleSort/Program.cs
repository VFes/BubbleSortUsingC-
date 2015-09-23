using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = new int[] { 13, 2, 6, 155, 5056, 1, 0, -1 };
            Console.WriteLine("Unsorted array:");

            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Console.WriteLine(unsortedArray[i]);
            }

            int[] sortedArray = SortrUsingBubbleSort(unsortedArray);
            Console.WriteLine("Bubble sorted");
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Console.WriteLine(sortedArray[i]);
            }

            Console.ReadLine();
        }

        //Some the most unefficient method for sorting but is the easiest, when you don´t care about speed
        //for example with 1 6 5 it checks the first and the second 1 and 3
        //1<6 so it stays like that (depending if ascending or descending)
        // if it were 6>1 you would switch between those
        //repeat with position 2 and 3 of the array (6 and 5)
        //We switch them to finish the sorting

        private static int[] SortrUsingBubbleSort(int[] unsortedArray)
        {
            int lenght = unsortedArray.Length;

            for (int i = 0; i < lenght -1; i++)
            {
                for (int j = 0; j < lenght -1 -i; j++)
                {
                  if(unsortedArray[j] < unsortedArray[j+1])
                  {
                      int num = unsortedArray[j];
                      unsortedArray[j] = unsortedArray[j + 1];
                      unsortedArray[j + 1] = num;
                  }
                }    
            } //Ends first for

            return unsortedArray;
        }//Finishes the method
    }
}
