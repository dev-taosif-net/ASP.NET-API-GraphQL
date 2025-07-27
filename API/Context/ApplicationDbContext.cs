using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Context;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public required DbSet<Movie> Movies { get; set; }
    public required DbSet<MovieReview> Reviews { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>().Property(e => e.Genre).HasConversion<string>();
    }
}
