using System;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to bubble sort");
            int[] a = { 4, 6, 3, 2, 5, 8, 8, 9 };
            BubbleSorting bubblesort = new BubbleSorting();
            bubblesort.BubbleSort();
        }
    }
}
