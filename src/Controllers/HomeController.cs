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

    public IActionResult Gestao_de_estoque()
    {
        // Buscar todos os produtos do banco de dados
        var produtos = _context.Produto.ToList();

        // Passar a lista de produtos para a view
        return View(produtos);
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
    public IActionResult Sucesso()
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

    [HttpPost]
    public ActionResult CadastrarProduto(ProdutoView modelo)
    {
        Console.WriteLine($"Dados que chegaram nome: {modelo.nome}, descricao {modelo.descricao}, preco: {modelo.preco}, categoria: {modelo.categoria}"); //agora testo no html e depois continuo a etapa
        Console.WriteLine($"Model is valid?: {ModelState.IsValid}");
        if (ModelState.IsValid){
             // Aqui você pode salvar os dados, por exemplo, em um banco de dados
            
            //Convertendo modelo a Fornecedor
            Produto produto = new Produto();
            produto.nome = modelo.nome;
            produto.categoria = modelo.categoria;
            produto.ativo = true;
            produto.fornecedor_id = 1;
            Console.WriteLine($"Dados convertidos a produtos: {produto.nome}, categoria: {produto.categoria}, ativo: {produto.ativo}, fornecedor_id: {produto.fornecedor_id}");

            //Mandando os dados para o banco de dados
            _context.Produto.Add(produto); // Adiciona o fornecedor ao contexto
            _context.SaveChanges(); // Salva as mudanças no banco de dados


            return RedirectToAction("Sucesso"); // Redireciona após salvar

        }

        return View(modelo);
    }


    public IActionResult Tabeladeproduto()
    {
        var produtosDb = _context.Produto.ToList();
        Console.WriteLine($"Dados da table produtos: {produtosDb} size: {produtosDb.Count}");

        var produtosView = new List<ProdutoView>();

        foreach (Produto produtoDb in produtosDb)
        {
            Console.WriteLine($"Dados do produto id: {produtoDb.nome}, categoria: {produtoDb.categoria}");

            produtosView.Add(new ProdutoView
            {
                nome = produtoDb.nome,
                descricao = "desconhecido",
                preco = "99,99",
                categoria = produtoDb.categoria
            });
        }


        var tabelaDeProdutoView = new TabelaDeProdutoView
        {
            produtos = produtosView
        };

        return View(tabelaDeProdutoView);
    }


    public IActionResult ListagemDeUsuario()
    {
        return View();
    }

    public IActionResult CadastroDeUsuario()
    {
        return View();
    }
}
