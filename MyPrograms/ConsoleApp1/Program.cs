
using ConsoleApp1.DataStructure.Tree;
using ConsoleApp1.LinkList;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 2, 5, 1, 10, 8, 20, 15, 100, 23, 12, 68 };
            Console.WriteLine("Selection Sort");
            SortingAlgorithums.SelectionSort(arr);

            int[] arr1 = new int[] { 3, 2, 5, 1, 10, 8, 20, 15, 100, 23, 12, 68 };
            Console.WriteLine("Bubble Sort");
            SortingAlgorithums.BubbleSort(arr1);

            int[] arr2 = new int[] { 3, 2, 5, 1, 10, 8, 20, 15, 100, 23, 12, 68 };
            Console.WriteLine("Insertion Sort");
            SortingAlgorithums.InsertionSort(arr2); Console.WriteLine();

            int[] arr3 = new int[] { 3, 2, 5, 1, 10, 8, 20, 15, 100, 23, 12, 68 };
            Console.WriteLine("Merge Sort");
            SortingAlgorithums.MergeSort(arr3);
            SortingAlgorithums.Print(arr3);

            int[] arr4 = new int[] { 3, 2, 25, 1, 10, 8, 68, 15, 100, 23, 12, 20 };
            Console.WriteLine("Quick Sort");
            SortingAlgorithums.QuickSort(arr4, 0, arr4.Length - 1);
            SortingAlgorithums.Print(arr4);

            Console.WriteLine();
            Console.ReadKey();

        }

        public static void ttrtretre()
        {
            string s = "abccbd";
            string newString = "";
            int cost = 0;

            int[] c = new int[6] { 0, 1, 2, 3, 4, 5 };
            var newArr = new List<int>();

            for (int index = 0; index < s.Length - 1; index++)
            {
                if (s[index].Equals(s[index + 1]))
                {
                    newArr.Add(index);
                }
            }

            foreach (int i in newArr)
            {
                cost += c[i];
                newString = newString + s[i];
                // newString = $"{s.Substring(0, i)}{s.Substring(i + 1)}";
            }

            Console.WriteLine(newString);
            Console.WriteLine(cost);
            Console.ReadKey();
        }

        public static void Print1(string input)
        {
            input = input.Substring(1);
            input = $"{input.Substring(0, 2)}){input.Substring(2)}";
        }

        public static void ttttt()
        {
            int count = 0;
            ////int lastReminder = 0;
            int a = 21;
            int b = 29;

            //for (int index = 2; index <= B; index++)
            //{
            //    //for (int i = 2; i <= 20; i++)
            //    //{
            //    //int reminder = index / 1;
            //    //if (lastReminder == reminder + 1)
            //    //{
            //    //    lastReminder = reminder;
            //    //    count++;
            //    //}
            //    var next = (index + 1);
            //    var result = index * next;
            //    if (result >= 6 && result <= 20)
            //    {
            //        count++;
            //    }
            //    //}
            //}

            //Console.WriteLine(count);
            for (int i = 2; i < b; i++)
            {
                int output = i * (i + 1);

                if (output <= b && output >= a)
                {
                    count++;
                }

                if (output > b)
                {
                    break;
                }
            }
        }
        public static void Print(string input)
        {
            //    Stack<char> stack = new Stack<char>();
            int dep = 0;
            int minDep = 0;
            foreach (char c in input)
            {
                if (c == '(')
                {
                    dep++;
                }
                else
                {
                    dep--;
                }

                if (minDep > dep)
                {
                    minDep = dep;
                }


            }

            if (minDep < 0)
            {
                for (int i = 0; i < Math.Abs(minDep); i++)
                    input = '(' + input;
            }

            dep = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                    dep++;
                else
                    dep--;
            }

            if (dep != 0)
            {
                for (int i = 0; i < dep; i++)
                    input = input + ')';
            }

            Console.Write(input);
        }
    }

}
