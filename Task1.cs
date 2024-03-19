using System;using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboretorna_robota2
{
    internal class Task1
    {
        public void Task(int[,] array)
        {
            for(int i = 0; i < array.GetLength(0); i++)
            { 
                int sumOfRow=0;
                for(int j = 0; j < array.GetLength(1); j += 2)
                {
                    sumOfRow += array[i, j];
                }
                WriteLine("Sum of row is "+sumOfRow);
            }
        }
    }
}
