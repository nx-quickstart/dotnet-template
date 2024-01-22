using Microsoft.EntityFrameworkCore;
using DotnetTemplate.Models;
using Microsoft.EntityFrameworkCore.Design;
/// <summary>
/// Represents the database context for the application.
/// </summary>
namespace DataAccessDb;

public class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
  {
  }
  public DbSet<DotnetTemplate.Models.User> Users { get; set; } = default!;
}


/// <summary>
/// Factory class for creating an instance of the <see cref="AppDbContext"/> during design time.
/// </summary>
public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
  /// <summary>
  /// Creates a new instance of the <see cref="AppDbContext"/> using the specified arguments.
  /// </summary>
  /// <param name="args">The command-line arguments.</param>
  /// <returns>An instance of the <see cref="AppDbContext"/>.</returns>
  public AppDbContext CreateDbContext(string[] args)
  {
    var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
    optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=pass");

    return new AppDbContext(optionsBuilder.Options);
  }
}



