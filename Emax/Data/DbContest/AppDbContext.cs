using Microsoft.EntityFrameworkCore;
using Emax.Domain.Entities;
namespace Emax.Data.DbContest;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<StudentGroup> StudentGroups { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=2007;Database=EmaxDb;Username=postgres;Password=0707");
    }
}
