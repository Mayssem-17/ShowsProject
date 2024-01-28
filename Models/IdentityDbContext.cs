using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ShowsProject.Models
{
    public class IdentityDbContext : IdentityDbContext<IdentityUser>
    {
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedRoles(builder);

            
        }
        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData
                (
                new IdentityRole() { Name = "Owner", ConcurrencyStamp = "1", NormalizedName ="Owner"},
                new IdentityRole() { Name = "Performer", ConcurrencyStamp="2", NormalizedName = "Performer"}


                );
        }



    }
}
