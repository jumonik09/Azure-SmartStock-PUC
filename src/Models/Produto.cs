namespace project.Models
{
    public class Produto
    {
        public int id { get; set; }
        public string? nome { get; set; }
        public string? categoria { get; set; }
        public byte ativo { get; set; }
        public int fornecedor_id { get; set; }
        public double? preco { get; set; }
        public int? quantidade { get; set; } //aqui
    }
}
