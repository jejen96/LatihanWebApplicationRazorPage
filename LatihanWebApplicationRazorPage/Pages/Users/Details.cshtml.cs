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
    public class DetailsModel : PageModel
    {
        private readonly LatihanWebApplicationRazorPage.Data.LatihanWebApplicationRazorPageContext _context;

        public DetailsModel(LatihanWebApplicationRazorPage.Data.LatihanWebApplicationRazorPageContext context)
        {
            _context = context;
        }

        public User Users { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.Users.FirstOrDefaultAsync(m => m.ID == id);
            if (users == null)
            {
                return NotFound();
            }
            else
            {
                Users = users;
            }
            return Page();
        }
    }
}
