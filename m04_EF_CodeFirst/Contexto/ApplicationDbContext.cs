using m04_EF_CodeFirst.Entidades;
using Microsoft.EntityFrameworkCore;

namespace m04_EF_CodeFirst.Contexto
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Categoria> Categorias { get; set; }
		public DbSet<Producto> Productos { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{

			optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=MicroGestionComercial;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Categoria>(entity =>
			{
				entity.HasKey(e => e.Id);
				entity.Property(e => e.Codigo)
							.IsRequired()
							.HasMaxLength(10);
				entity.Property(e => e.Nombre)
							.IsRequired()
							.HasMaxLength(50);
			});

			modelBuilder.Entity<Producto>(entity =>
			{
				entity.HasKey(e => e.Id);
				entity.Property(e => e.Codigo)
							.IsRequired()
							.HasMaxLength(10);
				entity.Property(e => e.Nombre)
							.IsRequired()
							.HasMaxLength(100);
			});
		}

	}
}
