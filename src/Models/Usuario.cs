namespace project.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public string Cargo { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public int Nivel { get; set; }
    }
}
