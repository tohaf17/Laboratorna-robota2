using Laboretorna_robota2;using static System.Math;
using System;using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Laboratorna_robota2
{
    public class Program
    {
        public static void RandomFilling(int m, int n,int[,] array)
        {
            int quantityOfRandom = (int)Pow(n, 2) * (int)Pow(m, 2) + 1;
            
            int maxLength = quantityOfRandom.ToString().Length;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = new Random().Next(0, quantityOfRandom);

                    Write($"{array[i, j].ToString().PadRight(maxLength + 1)}");
                }
                WriteLine();
            }
        }
        public static void UserInput(int n, int m,int[,] array)
        {
            for (int i = 0; i < n; i++)
            {
                string[] data = ReadLine().Trim().Split();
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = int.Parse(data[j]);
                }
            }
        }
        public static int[,] FillingOfArray()
        {
            Write("Please,input the number of rows: ");
            int rows = int.Parse(ReadLine());

            Write("Now input the number of columns: ");
            int columns = int.Parse(ReadLine());

            Write("Input the method of filling ");
            int choiceOfFilling = int.Parse(ReadLine());
            int[,] baseArray = new int[rows, columns];
            switch (choiceOfFilling)
            {
                case 1:
                    RandomFilling(rows, columns, baseArray);
                    break;
                case 2:
                    UserInput(rows, columns, baseArray);
                    break;
            }
            return baseArray;
        }
        public static void ChoosingOfTask(int[,] baseArray)
        {
            Write("Which of the tasks do you want to run? ");
            int numberOfTask = int.Parse(ReadLine());
            switch (numberOfTask)
            {
                case 1:
                    new Task1().Task(baseArray);
                    break;
                case 2:
                    new Task2().Task(baseArray);
                    break;
                case 3:
                    new Task3().Task(baseArray);
                    break;
                case 4:
                    new Task4().Task(baseArray);
                    break;
            }
        }
        static void Main(string[] args)
        {
            int[,] baseArray = FillingOfArray();

            ChoosingOfTask(baseArray);

            ReadKey();
        }
    }
}
