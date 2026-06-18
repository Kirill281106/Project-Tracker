using Microsoft.EntityFrameworkCore;
using Project_Tracker.Models;
namespace Project_Tracker.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<TaskItem> TaskItems { get; set; }
        public AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().
                HasMany(p=>p.Tasks).
                WithOne(ti=>ti.Project).
                HasForeignKey(ti=>ti.ProjectId).
                OnDelete(DeleteBehavior.Cascade);
        }
    }
}
