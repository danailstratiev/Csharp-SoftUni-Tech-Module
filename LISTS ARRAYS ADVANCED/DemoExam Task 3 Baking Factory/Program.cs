using System;
using System.Linq;
using System.Collections.Generic;


namespace DemoExam_Task_3_Baking_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            string batch = Console.ReadLine();
            List<int> badBatch = new List<int>();
            badBatch.Add(-1001);

            while (batch != "Bake It!")
            {
                var batchQuality = batch.Split("#").Select(int.Parse).ToList();
                if (batchQuality.Count <= 10)
                {                
                if (batchQuality.Sum() > badBatch.Sum() ||
                    (batchQuality.Sum() == badBatch.Sum() && batchQuality.Average() > badBatch.Average()) ||
                  (batchQuality.Sum() == badBatch.Sum() && batchQuality.Average() == badBatch.Average() && batchQuality.Count < badBatch.Count))
                {
                    badBatch = batchQuality;
                }                
                }
             batch = Console.ReadLine();
            }
            Console.WriteLine($"Best Batch quality: {badBatch.Sum()}");
            Console.WriteLine(string.Join(" ",badBatch));
        }
    }
}
