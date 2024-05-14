using Fiorello_MVC.Models;
using Fiorello_MVC.ViewModels.Blog;

namespace Fiorello_MVC.Services.Interfaces
{
    public interface IBlogService
    {
        Task<IEnumerable<BlogVM>> GetAllAsync();
    }
}
