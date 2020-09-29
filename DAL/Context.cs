
using Microsoft.EntityFrameworkCore;

namespace Registro.DAL
{
    public class Context : DbContext{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite(@"Data Source=Data/Parcial1.db");
        }
    }
}