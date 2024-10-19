namespace project.Models;

using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

public class TabelaDeFornecedorView{   

    public List<FornecedorView> fornecedores{ get; set; }


    // Construtor
    public TabelaDeFornecedorView()
    {
        fornecedores = new List<FornecedorView>(); // Inicializa a lista
    }
}