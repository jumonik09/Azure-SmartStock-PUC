namespace project.Models;

using System.ComponentModel.DataAnnotations;

public class ProdutoView{                                                     

    [Display(Name = "Nome do Produto:")]
    [Required(ErrorMessage = "Nome é obrigatório.")]
    public string nome {get;set;}

    [Display(Name = "Descrição")]
    [Required(ErrorMessage = "Descrição é obrigatório.")]
    public string descricao {get;set;}

    [Display(Name = "Preço:")]
    [Required(ErrorMessage = "Preço é obrigatório.")]
    public  string preco {get; set;}

    [Display(Name = "Categoria:")]
    [Required(ErrorMessage = "Categoria é obrigatório.")]
    public string categoria {get;set;} //juteste
}