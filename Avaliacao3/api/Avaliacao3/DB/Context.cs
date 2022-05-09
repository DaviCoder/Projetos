using Avaliacao3.Model;
using Microsoft.EntityFrameworkCore;

namespace Avaliacao3.DB
{
    public class Context : DbContext
    {
        public DbSet<Cliente_MD> cliente { get; set; }
        public DbSet<Error_MD> error { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Item dados = Config_JSON.LoadJson();
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            if(dados.nameSql == TipoBd.PostgreSql)
                optionsBuilder.UseNpgsql(string.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", dados.Host, dados.Port, dados.User, dados.Password, dados.Database));
            else if (dados.nameSql == TipoBd.SqlServer)
                optionsBuilder.UseSqlServer(string.Format("Server={0};User Id={1};Password={2};Database={3};", dados.Host, dados.User, dados.Password, dados.Database));
        }

        public static void CreateBase()
        {
            using (var context = new Context())
            {
                context.Database.EnsureCreated();
            }
        }
    }
}
