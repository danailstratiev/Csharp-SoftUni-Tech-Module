using System;
using System.Linq;


namespace Exercise_11._1_Equal_Sum_Alternative
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrofNums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            bool isFound = false;

            for (int i = 0; i < arrofNums.Length; i++)
            {
                int[] firstArr = arrofNums.Take(i).ToArray();
                int[] secondArr = arrofNums.Skip(i + 1).ToArray();

                if (firstArr.Sum() == secondArr.Sum())
                {
                    Console.WriteLine(i);
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
