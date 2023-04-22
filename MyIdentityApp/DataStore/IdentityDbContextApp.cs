using MyIdentityApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MyIdentityApp.DataStore
{
    public class IdentityDbContextApp : IdentityDbContext
    {
        public DbSet<AppUser> appUsers { get; set; }

        public IdentityDbContextApp(DbContextOptions<IdentityDbContextApp> options) : base(options)
        {

        }
    }
}
