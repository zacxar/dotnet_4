using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using dotnet_3.Models;
using dotnet_3.Data;
using System.Security.Claims;

namespace dotnet_3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public Person Person { get; set; }
        public IList<Person> PersonList = new List<Person>();

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            PersonList = _context.Person.ToList();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Person.isLeap();
                Person.Date = DateTime.Now;
                _context.Person.Add(Person);
                _context.SaveChanges();
                HttpContext.Session.SetString("Data", HttpContext.Session.GetString("Data") + Person.ToStringSession() + ".");
                return RedirectToPage("./Index");
            }
            return Page();
        }
    }
}