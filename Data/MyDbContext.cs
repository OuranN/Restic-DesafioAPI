using Microsoft.EntityFrameworkCore;
using MinhaApi.model;

public class MyDbContext : DbContext
{
    public DbSet<Cliente> Cliente { get; set; }
    public DbSet<Produto> Produto { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql(
                "Server=localhost;Port=3306;Database=MiniProjeto1;User=root;Password=root;",
                new MySqlServerVersion(new Version(8, 0, 39))
            );
        }
    }

    
}
