using lojaCafesApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace lojaCafesApp.Data;

public class DataContext : IdentityDbContext
{
    public DbSet<Cafe> Cafe { get; set; }
    public DbSet<TorraCafe> TorraCafe { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        string conn = config.GetConnectionString("Conn");
        optionsBuilder.UseSqlite(conn);
    }

}