using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel;
using Microsoft.EntityFrameworkCore;
using angels.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace angels.Data
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opt): base(opt)
        {
           
        }

        public DbSet<Product> products { get; set; }
    }
}
