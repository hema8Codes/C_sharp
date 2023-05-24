namespace Exercise_2_Stackoverflow
{
class StackOverflow
    {
        private List<Post> PostsList = new List<Post>();

        public int AddPost(Post post)
        {
            PostsList.Add(post);
            return PostsList.Count;
        }
        public Post GetPost(int id)
        {
            return PostsList[id];
        }
        public int PostCount()
        {
            return PostsList.Count;
        }
    }

    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        private readonly DateTime _PostTime = DateTime.Now;
        private int _VoteValue = 0;
        public Post()
        {
            Title = "";
            Description = "";
        }
        public void SetTitle(string title)
        {
            Title = title;
        }
        public DateTime PostTime()
        {
            return _PostTime;
        }
        public void SetDescription(string description)
        {
            Description = description;
        }

        public void UpVote()
        {
            _VoteValue++;
            if (_VoteValue == 0)
                _VoteValue++;
        }
        public void DownVote()
        {
            _VoteValue--;
            if (_VoteValue == 0)
                _VoteValue--;
        }
        public int GetVote()
        {
            return _VoteValue;
        }

    }

    class Program
    {
        public static void ViewPost(int Id, StackOverflow service)
        {
            if (service.PostCount() <= Id - 1 || Id == 0)
            {
                Console.Clear();
                Console.WriteLine("Please Enter Valid post number");
            }
            else
            {
                var post = service.GetPost(Id - 1);
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Post: {0}: Vote:{1}", post.Title, post.GetVote());
                    Console.WriteLine("Date Posted: " + post.PostTime());
                    Console.WriteLine(post.Description);
                    Console.WriteLine("Enter 'u' to up vote, 'd' to down vote or 'q' to quit.");
                    var input = Console.ReadLine().ToLower();
                    if (input == "q")
                    {
                        Console.Clear();
                        break;
                    }

                    switch (input)
                    {
                        case "u":
                            post.UpVote();
                            Console.Clear();
                            break;
                        case "d":
                            post.DownVote();
                            Console.Clear();
                            break;
                        default:
                            Console.Clear();
                            break;
                    }
                }
            }
        }
        public static void CreatePost(StackOverflow service)
        {
            var post = new Post();

            Console.WriteLine("Enter Title:");
            post.Title = Console.ReadLine();
            Console.WriteLine("Enter Description:");
            post.Description = Console.ReadLine();
            Console.Clear();
            service.AddPost(post);
            ViewPost(service.PostCount(), service);

        }

        static void Main(string[] args)
        {
            var service = new StackOverflow();
            while (true)
            {
                Console.WriteLine("Total current posts: " + service.PostCount());
                Console.WriteLine("Enter the post number to view it, 'n' to create a new post or 'q' to quit");
                var input = Console.ReadLine().ToLower();
                if (input == "q")
                    break;
                if (input.All(char.IsDigit))
                    ViewPost(Convert.ToInt32(input), service);
                if (input == "n")
                    CreatePost(service);
            }
        }
    }
}
