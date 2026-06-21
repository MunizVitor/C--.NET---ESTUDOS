using Microsoft.EntityFrameworkCore;
using WebApiCsharp.Model;

namespace WebApiCsharp.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Funcionario> Funcionario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(
          "Server=localhost;" +
          "Port=5432;Database=webapi_Csharp;" +
          "User Id=postgres;" +
          "Password=admin;");
    }
}
