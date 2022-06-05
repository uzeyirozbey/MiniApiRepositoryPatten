using AppRepositoryPatten.Entities.Models;
using Microsoft.EntityFrameworkCore;
namespace AppRepositoryPatten.Entities;
public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options)
         : base(options)
    {
    }
    public DbSet<Ogrenci> Ogrenciler { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}