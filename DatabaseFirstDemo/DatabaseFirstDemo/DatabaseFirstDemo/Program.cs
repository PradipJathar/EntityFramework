using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DatabaseFirstDemoEntities();

            var post = new Post
            {
                Body = "Body",
                DatePublished = DateTime.Now,
                Title = "Title",
                PostId = 1
            };

            db.Posts.Add(post);

            db.SaveChanges();

        }
    }
}
