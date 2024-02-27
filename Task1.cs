using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboretorna_robota2
{
    internal class Task1
    {
        public int[,] array;
        public Task1(int[,] _array)
        {
            array = _array;
        }
        public int[,] Arr
        {
            get{ return array; }
            set{ array = value; }
        }
        public void Task(int[,] array)
        {
           
            for(int i = 0; i < array.GetLength(0); i++)
            { int sumOfRow=0;
                for(int j = 1; j < array.GetLength(1); j += 2)
                {
                    sumOfRow += array[i, j];
                }
                Console.WriteLine("Sum of row is "+sumOfRow);
            }
        }
    }
}
