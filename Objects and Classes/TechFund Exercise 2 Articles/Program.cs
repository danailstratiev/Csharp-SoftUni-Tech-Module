using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Exercise_2_Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mainInput = Console.ReadLine().Split(", ").ToArray();
            Article article = new Article();
            article.Title = mainInput[0];
            article.Content = mainInput[1];
            article.Author = mainInput[2];

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                mainInput = Console.ReadLine().Split(": ").ToArray();
                switch (mainInput[0])
                {
                    case "Edit":
                        article.Content = mainInput[1];
                        break;
                    case "ChangeAuthor":
                        article.Author = mainInput[1];
                        break;
                    case "Rename":
                        article.Title = mainInput[1];
                        break;
                }
            }
            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
        }
    }
    class Article
    {
      public string Title { get; set; }
      public string Content { get; set; }
      public string Author { get; set; }       
    }
}
