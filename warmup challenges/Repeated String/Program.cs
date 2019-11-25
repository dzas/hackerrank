using System;
using System.IO;

namespace Repeated_String
{
    class Program
    {

        // Complete the repeatedString function below.
        static long RepeatedString(string s, long n)
        {
            long completeStrings = n / s.Length;
            long remainingLength = n % s.Length;
            long matchesInRemainingPart = 0;
            long matches = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    matches++;
                }

                if (remainingLength > 0 && i == remainingLength - 1)
                    matchesInRemainingPart = matches;
            }

            return matches * completeStrings + matchesInRemainingPart;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = RepeatedString(s, n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
