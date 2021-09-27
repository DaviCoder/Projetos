using Microsoft.EntityFrameworkCore;

namespace WebApplication.Models
{
    public class Context : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public Context(DbContextOptions<Context> options) : base(options){ }
    }
}