using Microsoft.EntityFrameworkCore;
using Workshop.Models;

namespace Workshop.Data;

public class WorkshopContext : DbContext
{
    public WorkshopContext(DbContextOptions<WorkshopContext> options)
        : base(options) { }

    public DbSet<WorkshopProject> WorkshopProjects => Set<WorkshopProject>();

    protected override void OnModelCreating(ModelBuilder b)
    {
        // Перетворення decimal у double для коректного сортування та агрегації в SQLite
        b.Entity<WorkshopProject>().Property(x => x.MaterialCost).HasConversion<double>();
        b.Entity<WorkshopProject>().Property(x => x.SalePrice).HasConversion<double>();
    }
}