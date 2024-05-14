using Fiorello_MVC.Data;
using Fiorello_MVC.Models;
using Fiorello_MVC.Services.Interfaces;
using Fiorello_MVC.ViewModels.Blog;
using Microsoft.EntityFrameworkCore;

namespace Fiorello_MVC.Services
{
    public class BlogService : IBlogService
    {
        private readonly AppDbContext _context;
        public BlogService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<BlogVM>> GetAllAsync()
        {
            return await _context.Blogs.Select(m=> new BlogVM { Title = m.Title,Description = m.Description, Image = m.Image, CreatedDate = m.CreatedDate.ToString("dd/mm/yyyy")}).ToListAsync();
        }
    }
}
