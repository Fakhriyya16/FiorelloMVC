using Fiorello_MVC.Models;
using Fiorello_MVC.ViewModels.Blog;

namespace Fiorello_MVC.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public SliderInfo SliderInfo { get; set; }
        public IEnumerable<BlogVM> Blogs { get; set; }
        public IEnumerable<Expert> Experts { get; set; }
    }
}
