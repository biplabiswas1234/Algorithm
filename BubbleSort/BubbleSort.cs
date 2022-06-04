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
        public void Anagram()
        {
            Console.WriteLine("Enter first string");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second string");
            string str2 = Console.ReadLine();
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            Console.WriteLine("After sorting\n");
            Console.WriteLine(ch1);
            Console.WriteLine(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("Both the strings are Anagrams");
            }
            else
            {
                Console.WriteLine("Both the strings are not Anagrams");
            }
        }
        public void Prime()
        {
            bool isPrime = true;
            int i, j;
            //Calculate and display the Prime number  
            Console.WriteLine("Enter number upto you want\n");
            int Num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime Numbers are : ");
            for (i = 2; i <= Num; i++)
            {
                for (j = 2; j <= i/2; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i +" ");
                }
                isPrime = true;
            }
            Console.ReadKey();
        }
    }
}

