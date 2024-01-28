using Microsoft.EntityFrameworkCore;

namespace ShowsProject.Models
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {

        }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Performer> Performers { get; set; }
        public DbSet<Application> Applications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Show>()
                .HasOne(s => s.Owner)
                .WithMany(o => o.Shows)
                .HasForeignKey(s => s.OwnerId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Application>()
                .HasOne(a => a.Show)
                .WithMany(s => s.Applications)
                .HasForeignKey(a => a.ShowId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Application>()
                .HasOne(a => a.Performer)
                .WithMany(p => p.Applications)
                .HasForeignKey(a => a.PerformerId)
                .OnDelete(DeleteBehavior.Cascade);


            base.OnModelCreating(modelBuilder);
        }


    }


    }




