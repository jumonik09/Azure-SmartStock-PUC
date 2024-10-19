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

    public IActionResult Tabeladefornecedor()
    {
        var fornecedoresDb = _context.Fornecedor.ToList();
        Console.WriteLine($"Dados da table fornecedor: {fornecedoresDb} size: {fornecedoresDb.Count}");

        var fornecedoresView = new List<FornecedorView>(); 

        foreach (Fornecedor fornecedorDb in fornecedoresDb)
        {
            Console.WriteLine($"Dados do fornecedor id: {fornecedorDb.id}, razao: {fornecedorDb.razao}");

           fornecedoresView.Add(new FornecedorView { 
                nome = fornecedorDb.razao, 
                email = fornecedorDb.email, 
                cnpj = "",
                endereco = "", 
                telefone = fornecedorDb.telefone,
            });
        }

        var tabelaDeFornecedorView = new TabelaDeFornecedorView
        {
            fornecedores = fornecedoresView
        };

        return View(tabelaDeFornecedorView);
    
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


    [HttpPost]
    public ActionResult CadastrarUsuario(UsuarioView modelo)
    {
        Console.WriteLine($"Dados que chegaram nome: {modelo.Nome}"); //agora testo no html e depois continuo a etapa
        Console.WriteLine($"Model is valid?: {ModelState.IsValid}");
        if (ModelState.IsValid)
        {
            // Aqui você pode salvar os dados, por exemplo, em um banco de dados

            //Convertendo modelo a Usuario
            Usuario usuario = new Usuario();
            usuario.Nome = modelo.Nome;
            usuario.Telefone = modelo.Telefone;
            usuario.Cargo = modelo.Cargo;
            usuario.Email = modelo.Email;
            usuario.Senha = modelo.Senha;
            usuario.Ativo = true;
            usuario.Nivel = 1;
            Console.WriteLine($"Dados convertidos a usuario: {usuario.Nome}");

            //Mandando os dados para o banco de dados
            _context.Usuario.Add(usuario); // Adiciona o Usuario ao contexto
            _context.SaveChanges(); // Salva as mudanças no banco de dados

           
            return RedirectToAction("Sucesso"); // Redireciona após salvar

        }

        return RedirectToAction("Sucesso");
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
        var usuariosDb = _context.Usuario.ToList();
        Console.WriteLine($"Dados da table usuario: {usuariosDb} size: {usuariosDb.Count}");

        var usuariosView = new List<UsuarioView>();

        foreach (Usuario usuarioDb in usuariosDb)
        {
            Console.WriteLine($"Dados do produto id: {usuarioDb.Nome}, categoria: {usuarioDb.Email}");

            usuariosView.Add(new UsuarioView
            {
                Nome = usuarioDb.Nome,
                Telefone = usuarioDb.Telefone,
                Cargo = usuarioDb.Cargo,
                Email = usuarioDb.Email,
                Ativo = "",
                Senha = usuarioDb.Senha,
                Nivel = usuarioDb.Nivel
            });
        }

        var listagemDeUsuariosView = new ListagemDeUsuarioView
        {
            ListaDeUsuario = usuariosView
        };
        return View(listagemDeUsuariosView);
    }

    public IActionResult CadastroDeUsuario()
    {
        return View();
    }
}



 
    