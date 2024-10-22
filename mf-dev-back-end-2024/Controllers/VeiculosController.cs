using mf_dev_back_end_2024.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
namespace mf_dev_back_end_2024.Controllers
{
    public class VeiculosController:Controller
    {
      private readonly AppDbContext _context;
            public VeiculosController(AppDbContext context)
        {
            _context = context;
        }
    public async Task<IActionResult> Index()
    {
        var dados = await _context.Veiculos.ToListAsync();
        return View(dados);
    }
        }
}
