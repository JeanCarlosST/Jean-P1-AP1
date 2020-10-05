
using Jean_P1_AP1.Entities;
using Microsoft.EntityFrameworkCore;

namespace Registro.DAL
{
    public class Context : DbContext{
        public DbSet<Ciudad> Ciudades { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite(@"Data Source=Data/Parcial1.db");
        }
    }
}