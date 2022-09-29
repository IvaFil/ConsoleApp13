using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи количество строк: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введи количество столбцов: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[,] arr = new double[m,n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i,j] = Convert.ToDouble(new Random().NextDouble());

                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i,j]+"   ");
                }
                Console.WriteLine();
            }
        }
    }
}
