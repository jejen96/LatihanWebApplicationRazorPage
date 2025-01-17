﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LatihanWebApplicationRazorPage.Data;
using LatihanWebApplicationRazorPage.Model;

namespace LatihanWebApplicationRazorPage.Pages.Users
{
    public class CreateModel : PageModel
    {
        private readonly LatihanWebApplicationRazorPage.Data.LatihanWebApplicationRazorPageContext _context;

        public CreateModel(LatihanWebApplicationRazorPage.Data.LatihanWebApplicationRazorPageContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public User Users { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Users.Add(Users);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
