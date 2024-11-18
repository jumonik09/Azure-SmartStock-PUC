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


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Deletar(int id)
        {
            Console.WriteLine($"Produto ID: {id}"); // Verifique se o ID está sendo recebido corretamente
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var produto = _context.Produto.FirstOrDefault(p => p.id == id);
                    if (produto == null)
                        return NotFound();

                    _context.Produto.Remove(produto);
                    _context.SaveChanges();
                    transaction.Commit(); // Se não ocorrer erro, confirma a transação
                    return Ok(); // Sucesso
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // Reverte a transação em caso de erro
                    Console.WriteLine($"Erro: {ex.Message}");
                    return StatusCode(500, "Erro ao tentar excluir o produto.");
                }
            }
        }



        /*
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Deletar(int id)
        {
            try
            {
                var produto = _context.Produto.Find(id);
                if (produto != null)
                {
                    _context.Produto.Remove(produto);
                    _context.SaveChanges(); // Salva as alterações no banco de dados
                    return Ok(); // Retorna status 200 para sucesso
                }

                return NotFound(); // Retorna status 404 se o produto não for encontrado
            }
            catch (DbUpdateException ex)
            {
                // Captura a exceção interna e registra no console
                string erroDetalhado = ex.InnerException?.Message ?? "Erro desconhecido";
                Console.WriteLine("Erro ao tentar excluir produto: " + erroDetalhado);

                // Retorna erro com mensagem detalhada
                return StatusCode(500, "Erro ao tentar excluir o produto. Detalhes: " + erroDetalhado);
            }
            catch (Exception ex)
            {
                // Para qualquer outro tipo de erro
                Console.WriteLine("Erro inesperado: " + ex.Message);
                return StatusCode(500, "Erro inesperado: " + ex.Message);
            }
        }
        */
    }
}