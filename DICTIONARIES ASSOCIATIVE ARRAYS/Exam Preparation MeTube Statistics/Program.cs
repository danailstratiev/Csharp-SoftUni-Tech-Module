using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace Exam_Preparation_MeTube_Statistics
{
    class Performer
    {
        public int Views { get; set; }

        public int Likes { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var statistics = new Dictionary<string, Performer>();

            while (input != "stats time")
            {
                var video = input.Split(new char[] { ':', '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (video[0] == "like" || video[0] == "dislike")
                {
                    var type = video[0];
                    var name = video[1];

                    if (!statistics.ContainsKey(name))
                    {
                        statistics[name] = new Performer();                       
                    }
                    var opinions = statistics[name];

                    if (type == "like")
                    {
                        opinions.Likes++;
                    }
                    else
                    {
                        opinions.Likes--;
                    }
                }
                else
                {
                    var name = video[0];
                    var views = int.Parse(video[1]);

                    if (!statistics.ContainsKey(name))
                    {
                        statistics[name] = new Performer();                      
                    }

                    var opinions = statistics[name];

                    opinions.Views += views;
                }

                input = Console.ReadLine();
            }

            string[] sorting = Console.ReadLine().Split(" ").ToArray();
            var sort = sorting[1];
            if (sorting[1] == "likes")
            {
                foreach (var performer in statistics.OrderByDescending(x => x.Value.Likes))
                {
                    Console.WriteLine($"{performer.Key} - {performer.Value.Views} views - {performer.Value.Likes} likes");
                }
            }
            else
            {
                foreach (var performer in statistics.OrderByDescending(x => x.Value.Views))
                {
                    Console.WriteLine($"{performer.Key} - {performer.Value.Views} views - {performer.Value.Likes} likes");
                }
            }
        }
    }
}
