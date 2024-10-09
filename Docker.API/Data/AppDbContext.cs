using Docker.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Docker.API.Data;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{
	}

	public DbSet<Users> Users { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.HasPostgresExtension("uuid-ossp");

		modelBuilder.Entity<Users>()
			.Property(t => t.Id)
			.HasDefaultValueSql("uuid_generate_v4()");
	}
}
