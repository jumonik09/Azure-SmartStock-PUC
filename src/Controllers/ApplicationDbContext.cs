using Microsoft.EntityFrameworkCore;
using project.Models;

public class ApplicationDbContext : DbContext
{
  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
  {

  }

  public DbSet<Fornecedor> Fornecedor { get; set; }
  public DbSet<Produto> Produto { get; set; }
  public DbSet<Usuario> Usuario { get; set; }
  public DbSet<OrdemDeCompra> OrdemDeCompra { get; set; }
  public DbSet<OrdemDeCompraProduto> OrdemDeCompraProduto { get; set; }
}
