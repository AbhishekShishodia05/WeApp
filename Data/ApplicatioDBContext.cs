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
    }
}
