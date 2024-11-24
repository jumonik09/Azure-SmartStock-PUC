using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project.Models;

namespace project.Controllers
{
    public class GeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GeController(ApplicationDbContext context)
        {
            _context = context;
        }



        public IActionResult EditarProduto(int id)
        {
            var produto = _context.Produto.Find(id); 
            if (produto == null)
            {
                TempData["Erro"] = "Produto não encontrado.";
                return RedirectToAction("Gestao_de_estoque", "Home");
            }
            return View("FazerEdicaoGE", produto); 
        }

        [HttpPost]
        public IActionResult EditarProduto(Produto produto)
        {
            if (ModelState.IsValid)
            {
                var produtoExistente = _context.Produto.Find(produto.id);

                if (produtoExistente != null)
                {
                    // Atualiza os campos do produto existente
                    produtoExistente.nome = produto.nome;
                    produtoExistente.quantidade = produto.quantidade;
                    produtoExistente.preco = produto.preco;

                    // Salva as alterações no banco de dados
                    _context.SaveChanges();

                    // Redireciona para a página de gestão de estoque após a edição
                    return RedirectToAction("Gestao_de_estoque", "Home");
                }
                else
                {
                    TempData["Erro"] = "Produto não encontrado.";
                    return RedirectToAction("Gestao_de_estoque", "Home");
                }
            }

            // Se o modelo não for válido, retorna a mesma view para correção
            return View("FazerEdicaoGE", produto);
        }
    }
}
