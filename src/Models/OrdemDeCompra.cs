using System.ComponentModel.DataAnnotations;

namespace project.Models
{
    public class OrdemDeCompra : IValidatableObject
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string? Status { get; set; }
        public double? Total { get; set; }
        public int UsuarioId { get; set; }
        public int FornecedorId { get; set; }
        public Fornecedor? Fornecedor { get; set; }
        public Usuario? Usuario { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (FornecedorId == 0)
            {
                yield return new ValidationResult("É necessário selecionar um fornecedor.", new[] { nameof(FornecedorId) });
            }

            if (UsuarioId == 0)
            {
                yield return new ValidationResult("É necessário selecionar um usuário.", new[] { nameof(UsuarioId) });
            }
        }
    }
}
