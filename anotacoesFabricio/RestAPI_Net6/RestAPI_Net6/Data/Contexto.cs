using Microsoft.EntityFrameworkCore;
using RestAPI_Net6.Models;

namespace RestAPI_Net6.Data
{
    public class Contexto : DbContext 
    {
        public DbSet<Pessoa> Pessoas { get; set; }


        public Contexto()
        {
            //Add-Migration Initial
            //Update-Database
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost;initial Catalog=API_Net6;User ID=usuario;password=senha;language=Portuguese;Trusted_Connection=True;");
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
