using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MyBlog.Data.Models;

namespace MyBlog.Data
{
    public class MyBlogDBContext : DbContext
    {
        public MyBlogDBContext(DbContextOptions<MyBlogDBContext> context) : base(context)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Tag> Tags { get; set; }
    }

    public class MyBlogDbContextFactory : IDesignTimeDbContextFactory<MyBlogDBContext>
    {
        public MyBlogDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyBlogDBContext>();

            optionsBuilder.UseSqlite("Data Source = test.db");

            return new MyBlogDBContext(optionsBuilder.Options);
        }
    }
}