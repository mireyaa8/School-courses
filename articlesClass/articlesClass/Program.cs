namespace articlesClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Articles articles = new Articles(input[0], input[1], input[2]);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(input, StringSplitOptions.RemoveEmptyEntries);
                switch (command[0])
                {     
                    case "Edit":
                        articles.Edit(command[1]);
                        break;
                    case "ChangeArthur":
                        articles.ChangeAuthor(command[1]);
                        break;
                    case "Rename":
                        articles.Rename(command[1]);
                        break;
                }
            }

        }
    }
    internal class Articles
    {
        private string tittle;
        private string contest;
        private string author;

        public string Contest
        {
            get { return contest; }
            set { contest = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Tittle
        {
            get { return tittle; }
            set { tittle = value; }
        }
        public Articles(string tittle, string author, string contest)
        {
            Tittle = tittle;
            Author = author;
            Contest = contest;
        }
        public string ChangeAuthor(string newContect)
        {
            return Author = newAuthor;
        }




    }

}