using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using project.Models;

namespace project.Controllers;

public class ProdutosView
{
    public int Id { get; set; }
    public int Quantidade { get; set; }
}

public class OrdemDeCompraController : Controller
{
    private readonly ApplicationDbContext _context;

    public OrdemDeCompraController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult CadastroOrdemDeCompra()
    {
        var model = new OrdemDeCompra();

        ViewBag.Fornecedores = _context.Fornecedor.Select(f => new SelectListItem { Value = f.id.ToString(), Text = f.razao }).ToList();
        ViewBag.Produtos = _context.Produto.Select(p => new SelectListItem { Value = $"{p.id}|{p.preco}", Text = p.nome }).ToList();
        ViewBag.Usuarios = _context.Usuario.Select(u => new SelectListItem { Value = u.id.ToString(), Text = u.Nome }).ToList();

        return View(model);
    }

    [HttpPost]
    public IActionResult CadastrarOrdemDeCompra(IFormCollection form)
    {
        var produtos = new List<ProdutosView>();
        var fornecedor = int.Parse(form["fornecedor"]);
        var usuario = int.Parse(form["usuario"]);
        var total = float.Parse(form["total"]);

        var OrdemDeCompra = new OrdemDeCompra { DataCriacao = DateTime.Today, FornecedorId = fornecedor, Status = "0", UsuarioId = usuario, Total = total };
        _context.OrdemDeCompra.Add(OrdemDeCompra);

        _context.SaveChanges();

        int index = 0;
        while (form[$"produtos[{index}][id]"].Count > 0)
        {
            int id = int.Parse(form[$"produtos[{index}][id]"]);
            int quantidade = int.Parse(form[$"produtos[{index}][quantidade]"]);

            produtos.Add(new ProdutosView { Id = id, Quantidade = quantidade });

            index++;
        }

        foreach (var produto in produtos)
        {
            _context.OrdemDeCompraProduto.Add(new OrdemDeCompraProduto { OrdemDeCompraId = OrdemDeCompra.Id, ProdutoId = produto.Id, Quantidade = produto.Quantidade });
        }

        _context.SaveChanges();

        return RedirectToAction("Sucesso", "Home");
    }
}
