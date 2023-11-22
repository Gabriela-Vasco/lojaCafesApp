using lojaCafesApp.Models;
using Microsoft.EntityFrameworkCore;
namespace WebApi.Helpers;

public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }


    public DataContext()
    {}

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite(Configuration.GetConnectionString("WebApiDatabase"));
    }

    public DbSet<Cafe> Cafe { get; set; }
    public DbSet<TorraCafe> TorraCafe { get; set; }
}