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


    [HttpPost]
    public ActionResult CadastrarFornecedor(FornecedorView modelo)
    {
        Console.WriteLine($"Dados que chegaram nome: {modelo.nome}, email: {modelo.email}, telefone: {modelo.telefone}, endereço: {modelo.endereco}, cnpj: {modelo.cnpj}");

        Console.WriteLine($"Model is valid?: {ModelState.IsValid}");

        if (ModelState.IsValid)
        {
            // Aqui você pode salvar os dados, por exemplo, em um banco de dados
            
            //Convertendo modelo a Fornecedor
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.razao = modelo.nome;
            fornecedor.email = modelo.email;
            fornecedor.endereco = modelo.endereco;
            fornecedor.telefone = modelo.telefone;

            Console.WriteLine($"Dados convertidos a fornecedor razao: {fornecedor.razao}, email: {fornecedor.email}, telefone: {fornecedor.telefone}, endereço: {fornecedor.endereco}");

            //Mandando os dados para o banco de dados
            _context.Fornecedor.Add(fornecedor); // Adiciona o fornecedor ao contexto
            _context.SaveChanges(); // Salva as mudanças no banco de dados


            return RedirectToAction("Sucesso"); // Redireciona após salvar
        }

        return View(modelo); // Retorna para o formulário se houver erros
    }
}