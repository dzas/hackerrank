using System;
using System.IO;

namespace _2D_Array___DS
{
    class Program
    {
        int HourglassSum(int[,] arr)
        {
            int[,] subArray = new int[3, 3];
            var w = arr.GetLength(0) / subArray.GetLength(0);
            var h = arr.GetLength(1) / subArray.GetLength(1);
            int[][,] glasses = new int[w * h][,];

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; i < h; i++)
                {
                    subArray
                }
            }

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
