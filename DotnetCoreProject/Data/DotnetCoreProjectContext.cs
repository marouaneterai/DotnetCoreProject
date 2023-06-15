using DotnetCoreProject.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetCoreProject.Data
{
    public class DotnetCoreProjectContext : DbContext
    {
        public DotnetCoreProjectContext(DbContextOptions<DotnetCoreProjectContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Project>().ToTable("Project");
            modelBuilder.Entity<Ticket>().ToTable("Ticket");
        }
    }
}
