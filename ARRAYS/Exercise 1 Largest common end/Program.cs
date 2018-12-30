using System;
using System.Linq;

namespace Exercise_1_Largest_common_end
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texts1 = Console.ReadLine().Split(' ').ToArray();
            string[] texts2 = Console.ReadLine().Split(' ').ToArray();
            int leftCount = 0;
            int rightCount = 0;

            for (int i = 0; i < Math.Min(texts1.Length,texts2.Length); i++)
            {
                if (texts1[i] == texts2[i])
                {
                    leftCount++;
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < Math.Min(texts1.Length,texts2.Length); i++)
            {
                if (texts1[texts1.Length-1-i] == texts2[texts2.Length-1-i])
                {
                    rightCount++;
                }
                else
                {
                    break;
                }
            }
            if (leftCount > rightCount)
            {
                Console.WriteLine(leftCount);
            }
            else
            {
                Console.WriteLine(rightCount);
            }
        }
    }
}
