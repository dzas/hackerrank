﻿using System;
using System.IO;

namespace Left_Rotation
{
    class Program
    {
        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            var rotCount = d % a.Length;

            var passes = a.Length - rotCount;
            var i = 1;
            for (int pass = a.GetUpperBound(0); pass > a.GetUpperBound(0) - passes; pass--)
            {
                var startIndex = pass;
                var passed = false;
                var src = startIndex;
                var srcVal = a[src];

                while (!passed)
                {
                    var dest = src - rotCount;
                    if (dest < 0)
                    {
                        dest = a.Length + dest;
                    }

                    var destVal = a[dest];
                    a[dest] = srcVal;
                    srcVal = destVal;
                    Console.WriteLine($"from {src} copy to {dest}");
                    src = dest;
                    passed = startIndex == dest;
                }
                Console.Write(string.Join(" ", a));
                Console.WriteLine($" - pass #{i}");
                i++;
            }

            return a;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            int[] result = rotLeft(a, d);

            textWriter.WriteLine(string.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
