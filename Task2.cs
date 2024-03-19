using System;using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboretorna_robota2
{
    internal class Task2
    {
        public static void Swap(int[,] arr,int i,int j,int k)
        {
            (arr[k, i], arr[k, j]) = (arr[k, j], arr[k,i]);
        }
        public static void BubbleSort(int n,int[,] arr,int k)
        {
            int min = 0,max= arr.GetLength(1)-1;
            for (int i = 1; i < arr.GetLength(1)-1; i++)
            {
                if (arr[k, i] < arr[k, min])
                {
                    min = i;
                }
                else if (arr[k, i] > arr[k, max])
                {
                    max = i;
                }
            }
            if (min != 0)
            {
                Swap(arr, 0, min, k);
            }
            if (max != arr.GetLength(1) - 1)
            {
                Swap(arr, arr.GetLength(1) - 1, max, k);
            }
        }
        public void PrintOfArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Write(arr[i, j] + " ");

                }
                WriteLine();
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
