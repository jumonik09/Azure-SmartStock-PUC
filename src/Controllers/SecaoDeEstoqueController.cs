using Microsoft.AspNetCore.Mvc;
using project.Models;
using System.Linq;

namespace project.Controllers
{
    [Route("estoque")]
    public class EstoqueController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EstoqueController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet("SecaoDeEstoque")]
        public IActionResult SecaoDeEstoque()
        {
            var produtos = _context.Produto.ToList();
            return View(produtos);

        }

        [HttpPost("adicionarProduto")]
        public JsonResult AdicionarProduto(string nome, int quantidade, float preco, string categoria)
        {
            var produto = new Produto
            {
                nome = nome,
                quantidade = quantidade,
                preco = preco,
                categoria = categoria
            };

            _context.Produto.Add(produto);
            _context.SaveChanges();

            return Json(produto);
        }

        [HttpPost("editarProduto")]
        public JsonResult EditarProduto(int id, string nome, int quantidade, float preco, string categoria)
        {
            var produto = _context.Produto.FirstOrDefault(p => p.id == id);
            if (produto != null)
            {
                produto.nome = nome;
                produto.quantidade = quantidade;
                produto.preco = preco;
                produto.categoria = categoria;

                _context.SaveChanges();
            }

            return Json(produto); // Retorna o produto editado
        }

        [HttpPost("excluirProduto")]
        public JsonResult ExcluirProduto(int id)
        {
            var produto = _context.Produto.FirstOrDefault(p => p.id == id);
            if (produto != null)
            {
                _context.Produto.Remove(produto);
                _context.SaveChanges();
            }

            return Json(new { success = true });
        }
    }
}
