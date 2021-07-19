using Microsoft.EntityFrameworkCore;
using WEB.API.Model;

namespace WEB.API.Data
{
    public class DatabaseContext : DbContext

    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Conexao.Dados);
            }
        }
    }
}
