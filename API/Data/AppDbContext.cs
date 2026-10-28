using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<AppUser> Users => Set<AppUser>();
    

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     base.OnModelCreating(modelBuilder);

    //     modelBuilder.Entity<AppUser>(user =>
    //     {
    //         user.Property(u => u.DisplayName).HasMaxLength(50);
    //         user.Property(u => u.Email).HasMaxLength(256);
    //         user.HasIndex(u => u.Email).IsUnique();
    //     });
    // }
}
