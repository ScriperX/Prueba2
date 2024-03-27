using Microsoft.EntityFrameworkCore;
using Prueba2.Data.Entities;

namespace Prueba2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<State> States { get; set; }
        



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
            // índice compuesto: Esta línea de código configura un índice único en la entidad State,
            // abarcando las columnas Name y CountryId, garantizando que no haya duplicados en estas columnas. Lo propio para City con State.
            modelBuilder.Entity<State>().HasIndex("Name", "CountryId" ).IsUnique();
            modelBuilder.Entity<City>().HasIndex("Name", "StateId" ).IsUnique();

        }
    }
}
