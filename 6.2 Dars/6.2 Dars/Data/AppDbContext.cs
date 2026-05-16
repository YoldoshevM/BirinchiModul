using _6._2_Dars.Configurations;
using _6._2_Dars.Entities;
using Microsoft.EntityFrameworkCore;

namespace _6._2_Dars.Data;

public class AppDbContext : DbContext
{


    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }


    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
    {
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(AppDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }


}
