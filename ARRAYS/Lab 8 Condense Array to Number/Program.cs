using System;
using System.Linq;



namespace Lab_8_Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int firstLenght = nums.Length - 1;
            int finalResult = 0;

            
            for (int i = 0; i < firstLenght; i++)
            {
            int[] condensed = new int[nums.Length - 1];
                for (int j = 0; j < condensed.Length; j++)
                {
                    condensed[j] = nums[j] + nums[j + 1];
                }
                    nums = condensed;
                finalResult = condensed[0];
            }
            Console.WriteLine(finalResult);
        }
    }
}
