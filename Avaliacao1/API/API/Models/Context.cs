using API.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class Context : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente{ClienteId = 1,Nome = "Davi",PorteEmpresa = PorteEmpresa.Grande},
                new Cliente{ClienteId = 2,Nome = "Abel",PorteEmpresa = PorteEmpresa.Medio},
                new Cliente{ClienteId = 3,Nome = "Laura",PorteEmpresa = PorteEmpresa.Pequeno}
            );
        }
    }
}