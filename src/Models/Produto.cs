namespace project.Models
{
    public class Produto
    {
        public int id { get; set; }
        public string? nome { get; set; }
        public string? categoria { get; set; }
        public bool ativo { get; set; }
        public int fornecedor_id { get; set; }
        public float? preco { get; set; }
    }
}
