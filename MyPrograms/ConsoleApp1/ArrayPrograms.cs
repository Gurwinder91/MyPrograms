using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class ArrayPrograms
    {
        public static void SortArrayByDescending()
        {
            int[] myArr = new int[10] { 98, 76, 99, 120, 180, 32, 77, 9, 200, 200};
            int i, j, temp;
            Console.Write("Elements: \n");
            for (i = 0; i < myArr.Length; i++)
            {
                Console.Write("{0} ", myArr[i]);
            }
            for (i = 0; i < myArr.Length; i++)
            {
                for (j = i + 1; j < myArr.Length; j++)
                {
                    if (myArr[i] < myArr[j])
                    {
                        temp = myArr[i];
                        myArr[i] = myArr[j];
                        myArr[j] = temp;
                    }
                }
            }
            Console.Write("\nDescending order:\n");
            for (i = 0; i < myArr.Length; i++)
            {
                Console.Write("{0} ", myArr[i]);
            }
            Console.Write("\n\n");
        }

        public static void SortArrayByAscending()
        {
            int[] myArr = new int[10] { 98, 76, 99, 120, 180, 32, 77, 9, 1, 200 };
            int i, j, temp;
            Console.Write("Elements: \n");
            for (i = 0; i < myArr.Length; i++)
            {
                Console.Write("{0} ", myArr[i]);
            }
            for (i = 0; i < myArr.Length; i++)
            {
                for (j = i + 1; j < myArr.Length; j++)
                {
                    if (myArr[i] > myArr[j])
                    {
                        temp = myArr[i];
                        myArr[i] = myArr[j];
                        myArr[j] = temp;
                    }
                }
            }

            Console.Write("\nDescending order:\n");
            for (i = 0; i < myArr.Length; i++)
            {
                Console.Write("{0} ", myArr[i]);
            }
            Console.Write("\n\n");
        }

        public static void FindMissingEntriesInArray()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 9 };

            int total = (arr.Length + 1) * (arr.Length + 2) / 2;

            for (int i = 0; i < arr.Length; i++)
                total -= arr[i];
            Console.Write(total);
        }

        public static void NthLargest(int[] arr)
        {
            int larget = 0;
            int secondLargest = 0;
            int thirdLargest = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (larget < arr[i])
                {
                    thirdLargest = secondLargest;
                    secondLargest = larget;
                    larget = arr[i];
                }
                else if (secondLargest < arr[i])
                {
                    thirdLargest = secondLargest;
                    secondLargest = arr[i];
                }

            }
        }
        public static void ThirdLargest(int[] arr, int arr_size)
        {
            /* There should be  
            atleast three elements */
            if (arr_size < 3)
            {
                Console.Write(" Invalid Input ");
                return;
            }

            // Find first  
            // largest element 
            int first = arr[0];
            for (int i = 1; i < arr_size; i++)
                if (arr[i] > first)
                    first = arr[i];

            // Find second 
            // largest element 
            int second = -int.MaxValue;
            for (int i = 0; i < arr_size; i++)
                if (arr[i] > second && arr[i] < first)
                    second = arr[i];

            // Find third  
            // largest element 
            int third = -int.MaxValue;
            for (int i = 0; i < arr_size; i++)
                if (arr[i] > third && arr[i] < second)
                    third = arr[i];

            Console.Write("The third Largest " + "element is " + third);
        }

        public static void MissingNumber(int[] arr, int count)
        {
            // 1,2,4,7,9
            // var count = arr.Length + 1;
            var missingRecords = count - arr.Length;
            
            var expectedCount = count * ((count + 1) / 2);
            var totalCount = 0;
            foreach (var item in arr)
            {
                totalCount += item;
            }

            Console.Write(expectedCount - totalCount);
        } 


    }
}
