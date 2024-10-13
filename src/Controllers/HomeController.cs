using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using project.Models;

namespace project.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var itens = _context.Fornecedor.ToList();
        Console.WriteLine($"Dados da table fornecedor: {itens} size: {itens.Count}");

        foreach (Fornecedor item in itens)
        {
            Console.WriteLine($"Dados do fornecedor id: {item.id}, razao: {item.razao} email: {item.email}, telefone: {item.telefone}");
        }

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }


    public IActionResult CadastroFornecedor()
    {
        return View();
    }

    public IActionResult CadastrarProduto()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}