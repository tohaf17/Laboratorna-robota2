using Laboretorna_robota2;
using System;
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
            int quantityOfRandom = (int)Math.Pow(n, 2) * (int)Math.Pow(m, 2) + 1;
            Random match = new Random();
            
            int maxLength = quantityOfRandom.ToString().Length;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = match.Next(0, quantityOfRandom);
                   
                    Console.Write($"{array[i, j].ToString().PadLeft((maxLength + 1) / 2 + maxLength).PadRight(maxLength + 1)}");
                }
                Console.WriteLine();
            }
        }
        public static void UserInput(int n, int m,int[,] array)
        {
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Trim().Split();
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = int.Parse(data[j]);
                }
            }
        }
        public static int[,] FillingOfArray()
        {
            Console.Write("Please,input the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Now input the number of columns: ");
            int columns = int.Parse(Console.ReadLine());

            Console.Write("Input the method of filling ");
            int choiceOfFilling = int.Parse(Console.ReadLine());
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
            Console.Write("Which of the tasks do you want to run? ");
            int numberOfTask = int.Parse(Console.ReadLine());
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

            Console.ReadKey();
        }
    }
}
