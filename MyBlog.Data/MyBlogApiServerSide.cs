using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Interfaces;
using MyBlog.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Data
{
    public class MyBlogApiServerSide : IMyBlogApi
    {
        private readonly IDbContextFactory<MyBlogDBContext> _factory;

        public MyBlogApiServerSide(IDbContextFactory<MyBlogDBContext> factory)
        {
            _factory = factory;
        }

        public async Task DeleteBlogPostAsync(BlogPost item)
        {
            await DeleteItem(item);
        }

        public async Task DeleteCategoryAsync(Category item)
        {
            await DeleteItem(item);
        }

        public async Task DeleteTagAsync(Tag item)
        {
            await DeleteItem(item);
        }

        public async Task<BlogPost> GetBlogPostAsync(int id)
        {
            using var context = _factory.CreateDbContext();

            return await context.BlogPosts
                .Include(p => p.Category)
                .Include(p => p.Tags)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<int> GetBlogPostCountAsync()
        {
            using var context = _factory.CreateDbContext();

            return await context.BlogPosts.CountAsync();
        }

        public async Task<List<BlogPost>> GetBlogPostsAsync(int numberOfPosts, int startIndex)
        {
            using var context = _factory.CreateDbContext();

            return await context.BlogPosts
                .OrderByDescending(p => p.PublishDate)
                .Skip(startIndex)
                .Take(numberOfPosts)
                .ToListAsync();
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            using var context = _factory.CreateDbContext();

            return await context.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryAsync(int id)
        {
            using var context = _factory.CreateDbContext();

            return await context.Categories
                .Include(p => p.BlogPosts)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Tag> GetTagAsync(int id)
        {
            using var context = _factory.CreateDbContext();

            return await context.Tags
                .Include(t => t.BlogPosts)
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<List<Tag>> GetTagsAsync()
        {
            using var context = _factory.CreateDbContext();

            return await context.Tags.ToListAsync();
        }

        public async Task<BlogPost> SaveBlogPostAsync(BlogPost item)
        {
            return (await SaveItem(item)) as BlogPost;
        }

        public async Task<Category> SaveCategoryAsync(Category item)
        {
            return (await SaveItem(item)) as Category;
        }

        public async Task<Tag> SaveTagAsync(Tag item)
        {
            return (await SaveItem(item)) as Tag;
        }

        private async Task DeleteItem(IMyBlogItem item)
        {
            using var context = _factory.CreateDbContext();

            context.Remove(item);

            await context.SaveChangesAsync();
        }

        private async Task<IMyBlogItem> SaveItem(IMyBlogItem item)
        {
            using var context = _factory.CreateDbContext();
            if (item.Id == 0)
            {
                context.Add(item);
            }
            else
            {
                if (item is BlogPost)
                {
                    var post = item as BlogPost;

                    var currentPost = await context.BlogPosts
                        .Include(p => p.Category)
                        .Include(p => p.Tags)
                        .FirstOrDefaultAsync(p => p.Id == post.Id);

                    currentPost.PublishDate = post.PublishDate;
                    currentPost.Title = post.Title;
                    currentPost.Text = post.Text;

                    var tagIds = post.Tags.Select(t => t.Id);

                    currentPost.Tags = context.Tags.Where(t => tagIds.Contains(t.Id)).ToList();

                    currentPost.Category = await context.Categories.FirstOrDefaultAsync(c => c.Id == post.Category.Id);

                    await context.SaveChangesAsync();
                }
                else // item is not BlogPost
                {
                    context.Entry(item).State = EntityState.Modified;
                }
            }
            await context.SaveChangesAsync();
            return item;
        }
    }
}