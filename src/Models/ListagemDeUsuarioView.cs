namespace project.Models;

using System.Collections.Generic;

public class ListagemDeUsuarioView {
    public List<UsuarioView> ListaDeUsuario { get; set; }

    //Construtor
    public ListagemDeUsuarioView()
    {
        ListaDeUsuario = new List<UsuarioView>();
    }
}
