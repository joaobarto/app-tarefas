using Microsoft.EntityFrameworkCore;
using app_tarefas.Models;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{
	}

	public DbSet<Tipo> Tipos { get; set; } = null!;
}