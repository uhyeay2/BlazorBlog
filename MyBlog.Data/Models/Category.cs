using MyBlog.Data.Interfaces;
using System.Collections.Generic;

namespace MyBlog.Data.Models
{
    public class Category : IMyBlogItem
    {
        public ICollection<BlogPost> BlogPosts { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}