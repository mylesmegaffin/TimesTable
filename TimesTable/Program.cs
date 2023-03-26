using System;

namespace TimesTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] timesTable = new int[,]
            {
                { 0, 0, 0, 0 },
                { 0, 1, 2, 3 },
                { 0, 2, 4, 6 },
                { 0, 3, 6, 9 },
            };

            Console.WriteLine("Let's go throw the times table: ");

            for(int i = 0; i < timesTable.GetLength(0); i++)
            {
                for(int j = 0; j < timesTable.GetLength(1); j++)
                {
                    Console.WriteLine($"{i} x {j} = {timesTable[i, j]}");
                }
            }
            Console.Read();
        }
    }
}
