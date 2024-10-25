using Microsoft.EntityFrameworkCore;

namespace project.Models
{
    public class OrdemDeCompraProduto
    {
        public int Id { get; set; }
        public int OrdemDeCompraId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
    }
}
