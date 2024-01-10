using Microsoft.EntityFrameworkCore;

namespace MigrationStudy.DBContext
{
    public class SalesDBContext : DbContext
        {
            public SalesDBContext(DbContextOptions options) : base(options)
            {
            }

            //setar qual a classe que vai ter os parametros para criação em banco
            public DbSet<SalesProducts> SalesProducts { get; set; }
        }
}

