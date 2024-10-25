using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using project.Models;

namespace project.Controllers;


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

}
