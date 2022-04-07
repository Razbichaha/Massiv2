using System;

namespace Massiv2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minRandom = 10;
            int maxRandom = 100;
            int line = 10;
            int column = 10;
            int[,] array = new int[line, column];

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int ii = 0; ii < array.GetLength(1); ii++)
                {
                    array[i, ii] = random.Next(minRandom, maxRandom);
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int ii = 0; ii < array.GetLength(1); ii++)
                {
                    Console.Write(array[i, ii] + " ");
                }

                Console.Write("\n");
            }

            int maxValue = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int ii = 0; ii < array.GetLength(1); ii++)
                {
                    if (array[i, ii] > maxValue)
                    {
                        maxValue = array[i, ii];
                    }
                }
            }

            Console.Write("\n");
            Console.Write("Максимальное число матрицы = "+maxValue+"\n");
            Console.Write("\n");
            int zero = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int ii = 0; ii < array.GetLength(1); ii++)
                {
                    if (array[i, ii] == maxValue)
                    {
                        array[i, ii] = zero;
                    }
                }
            }

            int alignOutputVariable = 10;

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int ii = 0; ii < array.GetLength(1); ii++)
                {
                    if(array[i,ii]<alignOutputVariable)
                    {
                        Console.Write(" "+array[i, ii] + " ");
                    }else
                    {
                        Console.Write(array[i, ii] + " ");
                    }
                }

                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
