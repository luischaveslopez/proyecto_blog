using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyBlog.Models;

namespace MyBlog.Pages.Posts
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public List<Post> Posts { get; set; }
        public List<Category> Categories { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? CategoryFilter { get; set; }

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
            Posts = new List<Post>();
            Categories = new List<Category>();
        }

        public async Task OnGetAsync()
        {
            var posts = from p in _context.Posts
                        select p;

            Categories = await _context.Categories.ToListAsync();

            if (!string.IsNullOrEmpty(SearchString))
            {
                posts = posts.Where(s => s.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(CategoryFilter))
            {
                posts = posts.Where(x => x.Category != null && x.Category.Name == CategoryFilter);
            }

            Posts = await posts.ToListAsync();
        }
    }
}
