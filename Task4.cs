using System;using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Laboretorna_robota2
{
    internal class Task4
    {
        public void FillingOfJudgeArray(int[,] array,out int[][] judgeArray)
        {
            judgeArray = new int[array.GetLength(0)][];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                judgeArray[i] = new int[array.GetLength(1)];
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    judgeArray[i][j] = array[i, j];
                }
            }
        }
        public void CountOfZerosInRows(int[][] array)
        {
            List<Tuple<int[], int>> tuples = new List<Tuple<int[], int>>();
            for (int i = 0; i < array.Length; i++)
            {
                int zeroCount = 0;
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] == 0)
                    {
                        zeroCount++;
                    }
                }
                tuples.Add(new Tuple<int[], int>(array[i], zeroCount));
            }
            tuples = tuples.OrderBy(b => b.Item2).ToList();
            PrintOfArray(tuples);
        }

        public void PrintOfArray(List<Tuple<int[], int>> rows)
        {
            foreach (var tuple in rows)
            {
                foreach (var value in tuple.Item1)
                {
                    Write(value + " ");
                }
                WriteLine();
            }
        }
        public void Task(int[,] array)
        {
            int[][] judgeArray;
            FillingOfJudgeArray(array, out judgeArray);
            CountOfZerosInRows(judgeArray);
        }
    }
}
