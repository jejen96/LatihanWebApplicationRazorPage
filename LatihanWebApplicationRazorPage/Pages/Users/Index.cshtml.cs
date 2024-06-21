using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LatihanWebApplicationRazorPage.Data;
using LatihanWebApplicationRazorPage.Model;

namespace LatihanWebApplicationRazorPage.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly LatihanWebApplicationRazorPage.Data.LatihanWebApplicationRazorPageContext _context;

        public IndexModel(LatihanWebApplicationRazorPage.Data.LatihanWebApplicationRazorPageContext context)
        {
            _context = context;
        }

        public IList<User> Users { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Users = await _context.Users.ToListAsync();
        }
    }
}
