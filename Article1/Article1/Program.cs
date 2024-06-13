﻿namespace Article1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
           .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Article article = new Article(input[0], input[1], input[2]);
            article.Edit("IT");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);
                switch (command[0])
                {
                    case "Edit":
                        article.Edit(command[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(command[1]);
                        break;
                    case "Rename":
                        article.Rename(command[1]);
                        break;
                }
            }
            Console.WriteLine(article.ToString());
        }
    }

    public class Article
    {


        public string Title
        {
            get; set;
        }

        public string Content
        {
            get; set;
        }

        public string Author
        {
            get; set;
        }
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Edit(string newContent)
        {
            return Content = newContent;
        }
        public string ChangeAuthor(string newAuthor)
        {
            return Author = newAuthor;
        }
        public string Rename(string newTitle)
        {
            return Title = newTitle;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author} ";
        }
    }
}

        
    
