namespace project.Models;
using System.ComponentModel.DataAnnotations;

public class UsuarioView
{
    [Display(Name = "Nome do Usuario:")]
    [Required(ErrorMessage = "Nome é obrigatório.")]
    public string Nome { get; set; }

    [Display(Name = "Telefone")]
    [Required(ErrorMessage = "Telefone é obrigatório.")]
    public int Telefone { get; set; }

    [Display(Name = "Cargo:")]
    [Required(ErrorMessage = "Cargo é obrigatório.")]
    public string Cargo { get; set; }

    [Display(Name = "Email:")]
    [Required(ErrorMessage = "Email é obrigatório.")]
    public string Email { get; set; } //juteste

    [Display(Name = "Senha:")]
    [Required(ErrorMessage = "Senha é obrigatório.")]
    public string Senha { get; set; }

    [Display(Name = "Ativo:")]
    [Required(ErrorMessage = "Ativo é obrigatório.")]
    public string Ativo { get; set; }

    [Display(Name = "Nivel:")]
    [Required(ErrorMessage = "Nivel é obrigatório.")]
    public int Nivel { get; set; }
}

