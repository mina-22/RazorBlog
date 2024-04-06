using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPlog.Data;
using RazorPlog.Models;
using RazorPlog.ViewModel;

namespace RazorPlog.Pages
{
    public class CreatBlogModel(ApplicationDbContext _database) : PageModel
    {

        [BindProperty]
        public Blog b { get; set; }


        public BlogType bt = new BlogType();



        [HttpGet]
        public void OnGet(int id)
        {
        
            bt.types = _database.types.ToList();
            if(id!=0)
               b = _database.blogs.Find(id);
        }


        [HttpPost]
        public IActionResult OnPost()
        {
            
            
            if (!ModelState.IsValid)
                return RedirectToPage();
            if(b.Id==0)
            {
                _database.blogs.Add(b);
                _database.SaveChanges();
            }
            else
            {
                
                _database.blogs.Update(b);
                _database.SaveChanges();
            }
           
            return RedirectToPage("ViewBlog");

        }
    }
}
