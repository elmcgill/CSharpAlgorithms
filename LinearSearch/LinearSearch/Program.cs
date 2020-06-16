using System;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 7;
            int[] arr = new int[] { 1, 4, 5, 7, 9, 22 };

            Console.Write("Our array contains: ");
            Array.ForEach(arr, x => Console.Write(x + " "));

            Console.WriteLine($"\nThe result of the search was index: {linearSearch(arr, val)}");
        }

        static int linearSearch(int[] a, int x)
        {
            int answer = -1;
            for(int i=0; i<a.Length; i++)
            {
                if(a[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
