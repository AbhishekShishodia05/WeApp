using Microsoft.EntityFrameworkCore;
using WeApp.Models;

namespace WeApp.Data
{
    public class ApplicatioDBContext : DbContext
    {
        public ApplicatioDBContext(DbContextOptions<ApplicatioDBContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Web Development", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Mobile Development", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Game Development", DisplayOrder = 3 }
            );
        }
    }
}
