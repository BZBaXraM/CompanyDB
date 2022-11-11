using Microsoft.EntityFrameworkCore;

namespace CompanyDB;

public sealed class AppContext : DbContext
{
    public DbSet<Company>? Companies { get; set; }
    public DbSet<Employees>? Employees { get; set; }
    public DbSet<Salaries>? Salaries { get; set; }

    public AppContext()
    {
        // Database.EnsureDeleted();
        // Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Поменяй провайдер подключение для MS SQL - и будет секас!)))
        optionsBuilder.UseNpgsql("Host=localhost;Port=5434;Database=CompanyDB;Username=postgres;Password=root");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Fluent Api
        modelBuilder.Entity<Company>().ToTable("Companies");
        modelBuilder.Entity<Employees>().ToTable("Employees");
        modelBuilder.Entity<Salaries>().ToTable("Salaries");
    }
}