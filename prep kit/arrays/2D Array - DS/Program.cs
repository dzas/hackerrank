using System;
using System.Collections.Generic;
using System.IO;

namespace _2D_Array___DS
{
    class Program
    {
        static int HourglassSum(int[,] arr)
        {
            int[,] subArray = new int[3, 3];
            var w = arr.GetLength(0) - subArray.GetLength(0) + 1;
            var h = arr.GetLength(1) - subArray.GetLength(1) + 1;
            int? prevSum = null;

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    int sum = 0;
                    sum += arr[i, j];
                    sum += arr[i, j + 1];
                    sum += arr[i, j + 2];
                    sum += arr[i + 1, j + 1];
                    sum += arr[i + 2, j];
                    sum += arr[i + 2, j + 1];
                    sum += arr[i + 2, j + 2];

                    if (prevSum == null)
                    {
                        prevSum = sum;
                    }
                    else if (prevSum < sum)
                    {
                        prevSum = sum;
                    }
                };
            }
            return prevSum.Value;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int[,] arr = new int[6, 6];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                var line = Console.ReadLine().Split(' ');

                for (int j = 0; j < line.Length; j++)
                {
                    arr[i, j] = Convert.ToInt32(line[j]);
                }
            }

            int result = HourglassSum(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
