namespace project.Models;

using System.ComponentModel.DataAnnotations;

public class FornecedorView{                                                     

    [Display(Name = "Nome do Fornecedor:")]
    [Required(ErrorMessage = "Nome é obrigatório.")]
    public string nome {get;set;}

    [Display(Name = "E-mail:")]
    [Required(ErrorMessage = "E-mail é obrigatório.")]
    public string email {get;set;}

    [Display(Name = "Telefone:")]
    [Required(ErrorMessage = "Telefone é obrigatório.")]
    public  string telefone {get; set;}

    [Display(Name = "Endereço:")]
    [Required(ErrorMessage = "Endereço é obrigatório.")]
    public string endereco {get;set;}

    [Display(Name = "CNPJ:")]
    [Required(ErrorMessage = "CNPJ é obrigatório.")]
    public string cnpj {get;set;}
}