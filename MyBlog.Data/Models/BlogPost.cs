using MyBlog.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace MyBlog.Data.Models
{
    public class BlogPost : IMyBlogItem
    {
        public Category Category { get; set; }

        public int Id { get; set; }

        public DateTime PublishDate { get; set; }

        public ICollection<Tag> Tags { get; set; }

        public string Text { get; set; }

        public string Title { get; set; }
    }
}