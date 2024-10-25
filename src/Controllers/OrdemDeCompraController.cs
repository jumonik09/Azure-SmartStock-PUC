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

}
