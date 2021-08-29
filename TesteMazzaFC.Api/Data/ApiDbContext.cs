using Microsoft.EntityFrameworkCore;
using TesteMazzaFC.Api.Model;

namespace TesteMazzaFC.Api.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options){ }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Categoria> Categorias { get; set; }
    }
}
