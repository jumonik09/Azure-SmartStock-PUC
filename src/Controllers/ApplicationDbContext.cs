using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Fornecedor> Fornecedor { get; set; } // Adicione suas entidades aqui

    public DbSet<Produto> Produto{ get; set; } // Adicione suas entidades aqui 
    //ju

}




