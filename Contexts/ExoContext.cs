using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext()
        {
        }

        public ExoContext(DbContextOptions<ExoContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Ajuste a string de conexão conforme seu ambiente local
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=ExoApi;Trusted_Connection=True;");
            }
        }

        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; } // <- Adicionado para a entidade Usuario
    }
}
