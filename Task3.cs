using System;using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboretorna_robota2
{
    public class Task3
    {
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
        public void Swap(int[,] array, int i,int j,int col)
        {
            (array[i, col], array[j, col]) = (array[j, col], array[i, col]);
        }
        public void SortOfColumns(int[,] array, int start)
        {
            for (int col = start; col < array.GetLength(1); col += 2)
            {
                for (int i = 0; i < array.GetLength(0) - 1; i++)
                {
                    for (int j = i + 1; j < array.GetLength(0); j++)
                    {
                        if ((start == 0 && array[j, col] < array[i, col]) || (start == 1 && array[j, col] > array[i, col]))
                        {
                            Swap(array, i, j, col);
                        }
                    }
                }
            }
        }

        public void Task(int[,] array)
        {
            SortOfColumns(array, 0);
            SortOfColumns(array, 1);
            PrintOfArray(array);
        }
    }
}
