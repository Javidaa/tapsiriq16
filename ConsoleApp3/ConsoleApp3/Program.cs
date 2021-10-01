using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Cavid", "Aliyev", "28.02.2001", "javidaa@code.edu.az", true);
            User user2 = new User("Elmir", "Dunyamaliyev", "04.11.2001", "dunyamaliyevelmir04@gmail.com", false);

            Post post1 = new Post("How are you");

            Comment comment1 = new Comment("Good,You");

            Post[] posts = { post1 };
            Comment[] comments = { comment1 };
            User[] commentedUser = { user2 };


            user1.Posts = posts;
        }
    }
}
