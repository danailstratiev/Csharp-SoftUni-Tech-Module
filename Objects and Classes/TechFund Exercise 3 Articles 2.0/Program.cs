using System;
using System.Linq;
using System.Collections.Generic;


namespace TechFund_Exercise_3_Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(", ").ToArray();
                Article article = new Article();
                article.Title = commands[0];
                article.Content = commands[1];
                article.Author = commands[2];
                articles.Add(article);
            }
            string input = Console.ReadLine();

            switch (input)
            {
                case "title":
                    foreach (var article in articles.OrderBy(x => x.Title))
                    {
                        Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
                    }
                    break;
                case "content":
                    foreach (var article in articles.OrderBy(x => x.Content))
                    {
                        Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
                    }
                    break;
                case "author":
                    foreach (var article in articles.OrderBy(x => x.Author))
                    {
                        Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
                    }
                    break;
            }
        }
    }
    // ("{title}, {content}, {author}"). 
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
}
