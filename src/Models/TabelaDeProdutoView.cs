namespace project.Models;

using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

public class TabelaDeProdutoView{   

    public List<ProdutoView> produtos { get; set; }


    // Construtor
    public TabelaDeProdutoView()
    {
        produtos = new List<ProdutoView>(); // Inicializa a lista
    }
}