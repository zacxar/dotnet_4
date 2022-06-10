using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using dotnet_3.Models;
using dotnet_3.Data;

namespace dotnet_3.Pages
{
    public class LastSearchModel : PageModel
    {
        public Person Person { get; set; }
        private readonly ApplicationDbContext _context;
        public List<Person> PersonList = new List<Person>();

        public LastSearchModel(ApplicationDbContext context)
        { 
            _context = context;
        }

        public void OnGet()
        {
            PersonList = _context.Person.OrderByDescending(p => p.Date).Take(20).ToList();
        }
    }
}
