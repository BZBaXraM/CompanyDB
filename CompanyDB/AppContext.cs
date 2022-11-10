using Microsoft.EntityFrameworkCore;

namespace CompanyDB;

public class AppContext : DbContext
{
    public DbSet<MyCompany>? Companies { get; set; }

    public AppContext()
    {
        //Database.EnsureDeleted();
        //Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Поменяй провайдер подключение для MS SQL - и будет секас!)))
        optionsBuilder.UseNpgsql("Host=localhost;Port=5434;Database=CompanyDB;Username=postgres;Password=root");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Fluent Api
        modelBuilder.Entity<MyCompany>().ToTable("Companies");
    }
}