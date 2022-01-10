using MyBlog.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyBlog.Data.Interfaces
{
    public interface IMyBlogApi
    {
        Task DeleteBlogPostAsync(BlogPost item);

        Task DeleteCategoryAsync(Category item);

        Task DeleteTagAsync(Tag item);

        Task<BlogPost> GetBlogPostAsync(int id);

        Task<int> GetBlogPostCountAsync();

        Task<List<BlogPost>> GetBlogPostsAsync(int numberOfPosts, int startIndex);

        Task<List<Category>> GetCategoriesAsync();

        Task<Category> GetCategoryAsync(int id);

        Task<Tag> GetTagAsync(int id);

        Task<List<Tag>> GetTagsAsync();

        Task<BlogPost> SaveBlogPostAsync(BlogPost item);

        Task<Category> SaveCategoryAsync(Category item);

        Task<Tag> SaveTagAsync(Tag item);
    }
}