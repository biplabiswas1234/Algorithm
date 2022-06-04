using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort
{
    public class BubbleSorting
    {
        public void BubbleSort()
        {
            Console.WriteLine("Enter array size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int temp = 0;
            for (int i = 0; i < size; i++)
            {
                int flag = 0;

                for (int j = 0; j < (size - i) - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        flag = 1;
                    }

                }
                if (flag == 0)
                {
                    break;
                }
            }
            Console.WriteLine("After bubble sort:\n");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}

