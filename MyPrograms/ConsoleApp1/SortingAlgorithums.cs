using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class SortingAlgorithums
    {
        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Print(arr);
        }

        public static void BubbleSort(int[] arr)
        {
            for (int k = 0; k < arr.Length; k++)
            {
                for (int i = 0; i < arr.Length - 1 - k; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        var temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }

            Print(arr);
        }

        public static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                var value = arr[i];
                var hole = i;
                while (hole > 0 && arr[hole - 1] > value)
                {
                    arr[hole] = arr[hole - 1];
                    hole = hole - 1;
                }
                arr[hole] = value;
            }

            Print(arr);
        }

        public static void MergeSort(int[] arr)
        {
            if (arr.Length < 2) return;

            int mid = arr.Length / 2;
            int[] arr1 = new int[mid];
            int[] arr2 = new int[arr.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                arr1[i] = arr[i];
            }

            for (int j = 0; j < arr2.Length; j++)
            {
                arr2[j] = arr[mid + j];
            }

            MergeSort(arr1);
            MergeSort(arr2);
            Merge(arr, arr1, arr2);
        }
        private static void Merge(int[] arr, int[] leftArr, int[] rightArr)
        {
            int k = 0, l = 0, r = 0;

            while (l < leftArr.Length && r < rightArr.Length)
            {
                if (leftArr[l] < rightArr[r])
                {
                    arr[k] = leftArr[l];
                    l++;
                }
                else
                {
                    arr[k] = rightArr[r];
                    r++;
                }
                k++;
            }

            while (l < leftArr.Length)
            {
                arr[k] = leftArr[l];
                l++;
                k++;
            }

            while (r < rightArr.Length)
            {
                arr[k] = rightArr[r];
                r++;
                k++;
            }
            return;
        }

        public static void QuickSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int pivotIndex = FindRandomPivot(arr, start, end);
                QuickSort(arr, start, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, end);
            }
        }

        private static int FindRandomPivot(int[] arr, int start, int end)
        {
            int index = new Random().Next(start, end);
            var temp = arr[index];
            arr[index] = arr[end];
            arr[end] = temp;
            return FindPivot(arr, start, end);
        }

        private static int FindPivot(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int swapIndex = start;
            for (int i = start; i < end; i++)
            {
                if (arr[i] <= pivot)
                {
                    var temp = arr[swapIndex];
                    arr[swapIndex] = arr[i];
                    arr[i] = temp;
                    swapIndex++;
                }
            }

            var temp1 = arr[swapIndex];
            arr[swapIndex] = pivot;
            arr[end] = temp1;

            return swapIndex;
        }

        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                Console.Write(" ");
            }
            Console.Write(Environment.NewLine);
        }


    }
}
