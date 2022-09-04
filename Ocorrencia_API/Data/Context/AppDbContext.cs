using Microsoft.EntityFrameworkCore;
using Ocorrencia_API.Domain.Models;

namespace Ocorrencia_API.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        public DbSet<Ocorrencia> Ocorrencia { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
    }
}
