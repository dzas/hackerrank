using System;
using System.IO;

namespace Array_Manipulation
{
    class Program
    {
        // Complete the arrayManipulation function below.
        static long ArrayManipulation(int n, int[][] queries)
        {
            var a = new long[n];
            long largestValue = 0;

            for (int queryLineIndx = 0; queryLineIndx <= queries.GetUpperBound(0); queryLineIndx++)
            {
                var queryLine = queries[queryLineIndx];
                var start = queryLine[0] - 1;
                var end = queryLine[1] - 1;
                var queryValue = queryLine[2];

                for (int updateIndx = start; updateIndx <= end; updateIndx++)
                {
                    a[updateIndx] += queryValue;
                    if (a[updateIndx] > largestValue)
                    {
                        largestValue = a[updateIndx];
                    }
                }
            }

            return largestValue;
        }

        static long ArrayManipulation2(int n, int[][] queries)
        {
            var a = new long[n];
            long largestValue = 0;

            for (int queryLineIndx = 0; queryLineIndx <= queries.GetUpperBound(0); queryLineIndx++)
            {
                var queryLine = queries[queryLineIndx];
                var start = queryLine[0] - 1;
                var end = queryLine[1] - 1;
                var queryValue = queryLine[2];

                for (int updateIndx = start; updateIndx <= end; updateIndx++)
                {
                    a[updateIndx] += queryValue;
                    if (a[updateIndx] > largestValue)
                    {
                        largestValue = a[updateIndx];
                    }
                }
            }

            return largestValue;
        }


        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[][] queries = new int[m][];

            for (int i = 0; i < m; i++)
            {
                queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            }

            long result = ArrayManipulation(n, queries);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
