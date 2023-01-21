using Courswork.Areas.Identity.Data;
using Courswork.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Courswork.Areas.Identity.Data;

public class AppDBContext : IdentityDbContext<AppUser>
{
    //public DbSet<AppUser> Users { get; set; }
    //public DbSet<Wheat> WheatTable { get; set; }
    //public DbSet<Rye> RyeTable { get; set; }



    public AppDBContext(DbContextOptions<AppDBContext> options)
        : base(options)
    {
        //Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
    }
}
