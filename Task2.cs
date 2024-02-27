using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboretorna_robota2
{
    internal class Task2
    {
        
        public int[,] array;
        public Task2(int[,] _array)
        {
            array = _array;
        }
        public int[,] Array
        {
            get { return array; }
            set { array = value; }
        }
        public static void Swap(int[,] arr,int i,int j,int k)
        {
            int temp = arr[k, i];
            arr[k, i] = arr[k, j];
            arr[k, j] = temp;
        }
        public static void BubbleSort(int n,int[,] arr,int k)
        {
            bool swapped = false;
            for(int i = 0; i < n - 1; i++)
            {
                for(int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[k, j] > arr[k, j + 1])
                    {
                        Swap(arr, j, j + 1, k);
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break ;
                }
            }
        }
        public void PrintOfArray(int[,] arr)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");

                }
                Console.WriteLine();
            }
        }
    
        public void Task(int[,] array)
        {
            int n = array.GetLength(1);
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    BubbleSort(n, array, i);
                }
            }
            PrintOfArray(array);
        }
    }
}
