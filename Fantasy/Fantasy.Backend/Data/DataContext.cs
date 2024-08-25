using Fantasy.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fantasy.Backend.Data;

public class DataContext : DbContext
{
    //constructor
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {        
    }

    //cada tabla es una propiedad
    public DbSet<Country> Countries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //tabla country vas a tener un indice por nombre y vas a ser un indice unico
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Country>().HasIndex(x => x.Name).IsUnique();
    }
}
