using System;
using static System.Console;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int theValue = 43;
            int[] array = new int[] { 11, 22, 43, 54, 57, 59, 62, 78 };

            WriteLine("Our array contains: ");
            Array.ForEach(array, x => Write(x + " "));

            Write($"\n\n The result of a binary search for {theValue} is: ");
            WriteLine(binarySearch(array, theValue));
        }

        /// <summary>
        /// a= array
        /// x= what we are searching
        /// p=first index
        /// q=midpoint
        /// r=last index
        /// </summary>


        public static int binarySearch(int[] a, int x)
        {
            // step 1 - initialize the variables
            int p = 0; //begining of the range
            int r = a.Length - 1;//end of the array

            //step 2 - searching for the value
            while(p <= r)
            {
                int q = (p + r) / 2;
                if (x < a[q])
                {
                    r = q - 1;
                }
                else if (x > a[q])
                {
                    p = q + 1;
                }
                else return q;
            }
            return -1;
        }
    }
}
