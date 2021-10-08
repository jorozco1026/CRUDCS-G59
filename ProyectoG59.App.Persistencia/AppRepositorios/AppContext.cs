using Microsoft.EntityFrameworkCore;
using ProyectoG59.App.Dominio.Entidades;

namespace ProyectoG59.App.Persistencia.AppRepositorios
{
    public class AppContext : DbContext
    {
         public DbSet<Formador> Formadores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
               .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =ProyectoG59");
            }
         }    
    }
}
