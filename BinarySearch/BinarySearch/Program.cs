using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int theVal = 43;
            int[] arr = new int[] { 11, 22, 43, 54, 57, 59, 62, 78 };

            Console.WriteLine("Our array contains: ");
            Array.ForEach(arr, x => Console.Write(x + " "));

            Console.WriteLine($"\nThe result of the binary search is {binarySearch(arr, theVal)}");
        }

        /// <summary>
        /// a = array
        /// x = what were looking for
        /// p = first index
        /// q = midpoint
        /// r = last index
        /// </summary>
        public static int binarySearch(int[] a, int x)
        {
            //Step 1 init vars
            int p = 0;
            int r = a.Length-1;

            //Step 2 do the search
            while(p<= r)
            {
                int q = (p + r) / 2; //Get the midpoint of the arr
                if(x < a[q])
                {
                    r = q - 1;
                } 
                else if (x > a[q])
                {
                    p = q + 1;
                }
                else
                {
                    return q;
                }
            }

            //Step 3 nothing found
            return -1;
        }
    }
}
