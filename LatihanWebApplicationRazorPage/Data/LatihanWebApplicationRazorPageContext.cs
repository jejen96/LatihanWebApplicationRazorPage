using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LatihanWebApplicationRazorPage.Model;

namespace LatihanWebApplicationRazorPage.Data
{
    public class LatihanWebApplicationRazorPageContext : DbContext
    {
        public LatihanWebApplicationRazorPageContext (DbContextOptions<LatihanWebApplicationRazorPageContext> options)
            : base(options)
        {
        }

        public DbSet<LatihanWebApplicationRazorPage.Model.User> Users { get; set; } = default!;
    }
}
