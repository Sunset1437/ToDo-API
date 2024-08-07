using Microsoft.EntityFrameworkCore;
using ToDo_APIv1.Models;

namespace ToDo_APIv1.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Users> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().Property(e=>e.Id).ValueGeneratedOnAdd();
            base.OnModelCreating(modelBuilder);
        }
    }

}
