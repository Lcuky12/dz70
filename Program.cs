using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp65
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = { { 1, 2, 3, }, { 4, 5, 6, }, { 5, 6, 7, } };

            int sum = 0;
            int multiplication = 1;
            int indexZero = 0;
            int indexOne = 1;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                multiplication *= numbers[indexZero, i];
            }

            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                sum += numbers[j, indexOne];
            }

            Console.WriteLine(" Сумма второй строки - " + sum);
            Console.WriteLine(" Произведение первого столбца - " + multiplication);
        }
    }
}