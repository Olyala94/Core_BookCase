using Microsoft.EntityFrameworkCore;

namespace Core_Departman2.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=BirimDb; integrated security=true;");

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Birim> Birims { get; set; }

        public DbSet<Personel> Personels { get; set; }

        public DbSet<Admin> Admins { get; set; }    
    }
}
