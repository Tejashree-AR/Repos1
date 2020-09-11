using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
    class Program
    {
        static void Main(string[] args)
        {
            Post1 post = new Post1("Does my post work?", "Test to see if my post works.");
            System.Console.WriteLine($"Title: {post.Title}");
            System.Console.WriteLine($"Description: {post.Description}");
            System.Console.WriteLine($"Date Created: {post.TimeDateCreated}");
            System.Console.WriteLine($"Post Count: {post.VoteCount}");
            post.VoteDown();
            System.Console.WriteLine($"Post Count: {post.VoteCount}");
            post.VoteUp();
            System.Console.WriteLine($"Post Count: {post.VoteCount}");
            Console.ReadLine();
        }
    }
}
