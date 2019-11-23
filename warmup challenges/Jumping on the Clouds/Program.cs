using System;
using System.IO;

namespace Jumping_on_the_Clouds
{
    class Program
    {
        enum CloudType
        {
            Cumulus = 0,
            Thunderhead = 1
        }

        static int JumpingOnClouds(int[] clouds)
        {
            int cloudIndex = 0;
            int jumps = 0;
            int shortJumpLength = 1;
            int farJumpLength = 2;

            while (cloudIndex < clouds.Length - 1)
            {
                int jumpLength;

                if ((cloudIndex + farJumpLength <= clouds.Length - 1) &&
                    (CloudType)clouds[cloudIndex + farJumpLength] == CloudType.Cumulus)
                {
                    jumpLength = farJumpLength;
                }
                else
                {
                    jumpLength = shortJumpLength;
                }

                cloudIndex += jumpLength;
                jumps++;
            }

            return jumps;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int cloudsCount = Convert.ToInt32(Console.ReadLine());

            int[] clouds = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));

            int result = JumpingOnClouds(clouds);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
