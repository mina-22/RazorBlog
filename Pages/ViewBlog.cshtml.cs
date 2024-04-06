using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPlog.Data;
using RazorPlog.Models;

namespace RazorPlog.Pages
{
    public class ViewBlogModel(ApplicationDbContext _database) : PageModel
    {
        [BindProperty]
        public List<Blog> blogs { get; set; }

        [HttpGet]
        public void OnGet()
        {
            blogs = _database.blogs.ToList();
            
        }

        [HttpDelete]
        public IActionResult OnPostDelete(int id)
        {
            var b = _database.blogs.Find(id);
            _database.blogs.Remove(b);
            _database.SaveChanges();
            return RedirectToPage("ViewBlog");
        }
    }
}
