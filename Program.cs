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
            int[,] Massiv = new int[line, column];

            for (int i = 0; i < Massiv.GetLength(0); i++)
            {

                for (int ii = 0; ii < Massiv.GetLength(1); ii++)
                {
                    Massiv[i, ii] = random.Next(minRandom, maxRandom);
                }
            }

            for (int i = 0; i < Massiv.GetLength(0); i++)
            {

                for (int ii = 0; ii < Massiv.GetLength(1); ii++)
                {
                    Console.Write(Massiv[i, ii] + " ");
                }

                Console.Write("\n");
            }

            int maxValue = 0;

            for (int i = 0; i < Massiv.GetLength(0); i++)
            {

                for (int ii = 0; ii < Massiv.GetLength(1); ii++)
                {
                    if (Massiv[i, ii] > maxValue)
                    {
                        maxValue = Massiv[i, ii];
                    }
                }
            }

            Console.Write("\n");
            Console.Write("Максимальное число матрицы = "+maxValue+"\n");
            Console.Write("\n");
            int zero = 0;

            for (int i = 0; i < Massiv.GetLength(0); i++)
            {
                for (int ii = 0; ii < Massiv.GetLength(1); ii++)
                {
                    if (Massiv[i, ii] == maxValue)
                    {
                        Massiv[i, ii] = zero;
                    }
                }
            }
            
            for (int i = 0; i < Massiv.GetLength(0); i++)
            {

                for (int ii = 0; ii < Massiv.GetLength(1); ii++)
                {
                    if(Massiv[i,ii]<10)
                    {
                        Console.Write(" "+Massiv[i, ii] + " ");
                    }else
                    {
                        Console.Write(Massiv[i, ii] + " ");
                    }
                }

                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
