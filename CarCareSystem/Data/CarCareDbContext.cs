using CarCareSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarCareSystem.Data;
public class CarCareDbContext : DbContext
{
    public DbSet<Maintainence> Maintainences { get; set; }
    public DbSet<Car> Cars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string databasePath = Path.Combine(currentDirectory, "carcare.db");
        optionsBuilder.UseSqlite($"Data Source={databasePath}");
    }
}
