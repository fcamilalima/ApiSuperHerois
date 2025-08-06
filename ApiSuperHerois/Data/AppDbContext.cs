using ApiSuperHerois.Data.ContextConfigurations;
using ApiSuperHerois.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiSuperHerois.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var ids = new Guid[] {
            Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid()
        };

        modelBuilder.ApplyConfiguration(new SuperHeroiContextConfiguration(ids));
        modelBuilder.ApplyConfiguration(new SuperPoderContextConfiguration(ids));
        modelBuilder.ApplyConfiguration(new FilmeContextConfiguration(ids));
    }

    public DbSet<SuperHeroi> SuperHerois { get; set; }
    public DbSet<SuperPoder> SuperPoderes { get; set; }
    public DbSet<Filme> Filmes { get; set; }
}
