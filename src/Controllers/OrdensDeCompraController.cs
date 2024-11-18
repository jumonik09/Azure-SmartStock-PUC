using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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

    public IActionResult OrdensDeCompra()
    {
        return View();
    }


    public IActionResult CadastroOrdemDeCompra()
    {
        var model = new OrdemDeCompra();

        ViewBag.Fornecedores = _context.Fornecedor.Select(f => new SelectListItem { Value = f.id.ToString(), Text = f.razao }).ToList();
        ViewBag.Produtos = _context.Produto.Select(p => new SelectListItem { Value = $"{p.id}|{p.preco}", Text = p.nome }).ToList();
        ViewBag.Usuarios = _context.Usuario.Select(u => new SelectListItem { Value = u.id.ToString(), Text = u.Nome }).ToList();

        return View(model);
    }

    [HttpGet("OrdemDeCompra/")]
    public IActionResult GetOrdensDeCompra()
    {
        var ordensDeCompra = _context.OrdemDeCompra
           .Include(o => o.Fornecedor)
           .Include(o => o.Usuario)
           .Join(
               _context.OrdemDeCompraProduto,
               ordem => ordem.Id,
               ordemProduto => ordemProduto.OrdemDeCompraId,
               (ordem, ordemProduto) => new
               {
                   Ordem = ordem,
                   Produto = ordemProduto
               })
           .Join(
               _context.Produto,
               op => op.Produto.ProdutoId,
               produto => produto.id,
               (op, produto) => new
               {
                   op.Ordem.Id,
                   op.Ordem.DataCriacao,
                   op.Ordem.Status,
                   op.Ordem.Total,
                   FornecedorRazao = op.Ordem.Fornecedor != null ? op.Ordem.Fornecedor.razao : "Fornecedor não informado",
                   UsuarioNome = op.Ordem.Usuario != null ? op.Ordem.Usuario.Nome : "Usuário não informado",
                   ProdutoNome = produto.nome,
                   Quantidade = op.Produto.Quantidade,
                   PrecoProduto = produto.preco,
                   TotalProduto = op.Produto.Quantidade * produto.preco
               })
           .GroupBy(x => x.Id)
           .Select(g => new
           {
               Id = g.Key,
               DataCriacao = g.First().DataCriacao,
               Status = g.First().Status,
               Total = g.First().Total,
               FornecedorRazao = g.First().FornecedorRazao,
               UsuarioNome = g.First().UsuarioNome,
               Produtos = g.Select(p => new
               {
                   p.ProdutoNome,
                   p.Quantidade,
                   p.PrecoProduto,
                   p.TotalProduto
               }).ToList()
           })
           .OrderBy(o => o.Status)
           .ToList();

        return Json(ordensDeCompra);
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

    [HttpPost]
    public IActionResult AprovarOrdem(int id)
    {
        var ordem = _context.OrdemDeCompra.Find(id);
        if (ordem == null)
        {
            return NotFound();
        }

        ordem.Status = "1";
        _context.SaveChanges();

        return Ok();
    }
}
