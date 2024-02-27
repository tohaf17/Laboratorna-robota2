using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboretorna_robota2
{
    public class Task3
    {
        protected int[,] array;
        public Task3(int[,] array)
        {
            this.array = array;
        }
        public int[,] Array
        {
            get { return array; }
            set { array = value; }
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
        public void Swap(int[,] array, int i,int j,int col)
        {
            int temp = array[i, col];
            array[i, col] = array[j, col];
            array[j, col] = temp;
        }
        public void SortOfColumns(int[,] array,int start)
        {
            for(int col = start; col < array.GetLength(1); col += 2)
            {
                for (int i = 0; i < array.GetLength(0) - 1; i++)
                {
                    for (int j = i + 1; j < array.GetLength(0); j++)
                    {
                        if ((start==0)?array[j, col] > array[i, col]: array[j, col] < array[i, col])
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
