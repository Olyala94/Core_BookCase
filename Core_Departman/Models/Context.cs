using Microsoft.EntityFrameworkCore;

namespace Core_Departman.Models
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=CorePersonel; integrated security=true;");

			base.OnConfiguring(optionsBuilder);
		}

		public DbSet<Departman> Departmans { get; set; }

		public DbSet<Personel> Personels { get; set; }
    }
}
